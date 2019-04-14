using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Las_Delicias_WebAPI.Controllers.Repositorio
{
    public class UploadFTP
    {
        public static string Upload(string FileName, String ruta,HttpPostedFileBase imagenCrudo)
        {
            try
            {
                string extencion = System.IO.Path.GetExtension(FileName).ToLower();
                
                string rutaSubida = @"ftp://35.243.229.201/" + ruta + "/" + generarNombreImagen(extencion);

                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(rutaSubida);

                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new NetworkCredential("cucaracho", "4583013");

                request.UsePassive = true;

                request.UseBinary = true;

                request.KeepAlive = true;

                BinaryReader b = new BinaryReader(imagenCrudo.InputStream);

                byte[] buffer2 = b.ReadBytes(imagenCrudo.ContentLength);

                Stream reqStream = request.GetRequestStream();

                reqStream.Write(buffer2, 0, buffer2.Length);

                reqStream.Flush();

                reqStream.Close();
                string respuesta = "http://35.243.229.201" + rutaSubida.Substring(26, rutaSubida.Length - 26);
                return respuesta;

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return "";
            }

        }
        public static string generarNombreImagen(string ext)
        {
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "").Replace("/", "");
            return token.Substring(0, 7) + ext;
        }
        public static string generarToken()
        {
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "").Replace("/", "");
            return token.Substring(0, 8) ;
        }
    }
}