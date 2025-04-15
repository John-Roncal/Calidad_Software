using CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class datAPI
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datAPI _instancia = new datAPI();
        //privado para evitar la instanciación directa
        public static datAPI Instancia
        {
            get
            {
                return datAPI._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public Boolean InsertarProvincia(entContacto con)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsetarProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteId", con.Cliente.Id);
                cmd.Parameters.AddWithValue("@Propuesta", con.Propuesta);
                cmd.Parameters.AddWithValue("@Comentarios", con.Comentarios);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        private const string ApiUrl = "http://localhost:8000"; // URL de la API

        public async Task<string> GenerarContenidoAsync(string prompt)
        {
                try
                {
                    var content = new { prompt };
                    string jsonContent = JsonConvert.SerializeObject(content);
                    var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    using (var client = new HttpClient())
                    {
                        var response = await client.PostAsync($"{ApiUrl}/generar-contenido/", stringContent);

                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeAnonymousType(responseContent, new { contenido = "" });
                            return result.contenido;
                        }
                        else
                        {
                            throw new Exception($"Error al generar contenido: {response.StatusCode}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error: {ex.Message}");
                }
            }

        public async Task<string> EnviarCorreoAsync(int categoria, string tipo, string asunto, string mensaje, string archivoPath)
        {
            try
            {
                using (var client = new HttpClient())
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(categoria.ToString()), "categoria"); // Convertimos int a string
                    content.Add(new StringContent(tipo), "tipo");
                    content.Add(new StringContent(asunto), "asunto");
                    content.Add(new StringContent(mensaje), "mensaje");

                    // Agregar archivo PDF adjunto
                    var fileBytes = File.ReadAllBytes(archivoPath);
                    var fileContent = new ByteArrayContent(fileBytes);
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/pdf");
                    content.Add(fileContent, "archivo", Path.GetFileName(archivoPath));

                    // Enviar petición
                    var response = await client.PostAsync($"{ApiUrl}/enviar-correos-con-adjunto/", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeAnonymousType(responseContent, new { mensaje = "" });
                        return result.mensaje;
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Error al enviar correos: {errorContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

    }
    #endregion metodos
}

