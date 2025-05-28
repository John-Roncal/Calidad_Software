import pandas as pd
import pyodbc
from tkinter import *
from tkinter import ttk, filedialog, messagebox
from datetime import datetime

class ExcelImporter:
    def __init__(self, root):
        self.root = root
        self.root.title("Importador de Clientes")
        self.root.geometry("500x250")
        
        self.file_path = ""
        self.categoria = ""
        
        self.create_widgets()
    
    def create_widgets(self):
        main_frame = ttk.Frame(self.root, padding=20)
        main_frame.pack(expand=True, fill=BOTH)
        
        ttk.Label(main_frame, text="Archivo Excel:").grid(row=0, column=0, sticky=W)
        self.file_label = ttk.Label(main_frame, text="Ningún archivo seleccionado")
        self.file_label.grid(row=0, column=1, sticky=EW, padx=5)
        ttk.Button(main_frame, text="Examinar", command=self.select_file).grid(row=0, column=2)
        
        ttk.Label(main_frame, text="Categoría:").grid(row=1, column=0, sticky=W, pady=10)
        self.categoria_entry = ttk.Entry(main_frame, width=30)
        self.categoria_entry.grid(row=1, column=1, columnspan=2, sticky=EW, padx=5)
        
        self.import_btn = ttk.Button(
            main_frame, 
            text="Importar a SQL Server", 
            command=self.start_import,
            state=DISABLED
        )
        self.import_btn.grid(row=2, column=0, columnspan=3, pady=20)
        
        self.status_label = ttk.Label(main_frame, text="", foreground="red")
        self.status_label.grid(row=3, column=0, columnspan=3, sticky=W)
        
        main_frame.columnconfigure(1, weight=1)
    
    def select_file(self):
        file_types = [("Excel files", "*.xlsx;*.xls")]
        self.file_path = filedialog.askopenfilename(filetypes=file_types)
        if self.file_path:
            self.file_label.config(text=self.file_path)
            self.validate_form()
    
    def validate_form(self):
        if self.file_path and self.categoria_entry.get().strip():
            self.import_btn.config(state=NORMAL)
            self.status_label.config(text="")
        else:
            self.import_btn.config(state=DISABLED)
    
    def start_import(self):
        self.categoria = self.categoria_entry.get().strip()[:50]
        if not self.categoria:
            messagebox.showerror("Error", "La categoría no puede estar vacía")
            return
        
        try:
            self.import_data()
            messagebox.showinfo("Éxito", "Datos importados correctamente")
            self.root.destroy()
        except Exception as e:
            self.status_label.config(text=f"Error: {str(e)}", foreground="red")
            print(e)
    
    def import_data(self):
        df = pd.read_excel(self.file_path)
    
    # Renombrar columnas para uniformidad
        column_mapping = {
        "NOMBRE": "Nombre",
        "MAIL": "Mail",
        "WEB": "Web",
        "PROVINCIA": "Provincia"
        }
    
        df = df.rename(columns=column_mapping)
        df = df[["Nombre", "Mail", "Web", "Provincia"]]  # Solo columnas necesarias
        df = df.where(pd.notnull(df), None)

        conn = pyodbc.connect(
            "DRIVER={SQL Server};"
            "SERVER=LAPTOP-R58HSL2K;"
            "DATABASE=NorRevistaBD;"
            "Trusted_Connection=yes;"
        )
        cursor = conn.cursor()
    
    # Obtener o insertar categoría
        cursor.execute("SELECT Id FROM Categorias WHERE Nombre = ?", self.categoria)
        categoria_row = cursor.fetchone()
        if categoria_row:
            categoria_id = categoria_row[0]
        else:
            cursor.execute("INSERT INTO Categorias (Nombre) VALUES (?)", self.categoria)
            conn.commit()
            categoria_id = cursor.execute("SELECT SCOPE_IDENTITY()").fetchval()
    
        insert_query = '''
        INSERT INTO Clientes (
            Nombre, Mail, Web, ProvinciaId, CategoriaId
        ) 
        VALUES (?, ?, ?, ?, ?)
        '''
    
        for index, row in df.iterrows():
            try:
                provincia_nombre = str(row["Provincia"]).strip()

                # Verificar si la provincia ya existe
                cursor.execute("SELECT Codigo FROM Provincias WHERE Nombre = ?", provincia_nombre)
                provincia_row = cursor.fetchone()
                if provincia_row:
                    provincia_id = provincia_row[0]
                else:
                    # Generar un código único de 3 caracteres
                    base_codigo = provincia_nombre[:3].upper()
                    codigo = base_codigo
                    i = 1
                    while True:
                        cursor.execute("SELECT 1 FROM Provincias WHERE Codigo = ?", codigo)
                        if not cursor.fetchone():
                            break
                        codigo = f"{base_codigo[:2]}{i}" if i < 10 else f"{base_codigo[:1]}{i}"
                        i += 1

                    # Insertar nueva provincia
                    cursor.execute("INSERT INTO Provincias (Codigo, Nombre) VALUES (?, ?)", codigo, provincia_nombre)
                    conn.commit()
                    provincia_id = codigo

                values = (
                    str(row["Nombre"]).strip(),
                    str(row["Mail"]).strip(),
                    str(row["Web"]).strip() if row["Web"] else None,
                    provincia_id,
                    categoria_id
                )
                cursor.execute(insert_query, values)
            except Exception as e:
                print(f"Error en fila {index + 2}: {str(e)}")
                continue
        conn.commit()
        conn.close()


if __name__ == "__main__":
    root = Tk()
    app = ExcelImporter(root)
    app.categoria_entry.bind("<KeyRelease>", lambda e: app.validate_form())
    root.mainloop()
