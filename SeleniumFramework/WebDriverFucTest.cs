using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Web;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestingJquerySelenium
{
   public class WebDriverFucTest
    {
        public IWebDriver driver;
        public String Rutapordefecto = @"C:\Screenshots\";
        public String RutaAlterna = @"\Presentacion\";
        public bool banderarutaAlterna = false;
        //Funciones Jquery en el DOM para hacer generico el
        //código de los casos de pruebas
         
        public void DeleteVal(String SelectorJquery)
        {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("$('" + SelectorJquery + "').val('');");
        }
        public void DeleteText(String SelectorJquery)
        {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("$('" + SelectorJquery + "').text('');");

        }
        public void AddVal(String SelectorJquery, String Valor)
        {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("$('" + SelectorJquery + "').val('"+Valor+"');");
        }
        public void Excute(string jsstr)  {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(jsstr);



             }
        public bool ExcuteBool(string jsstr)
        {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            bool algo =(bool)js.ExecuteScript("return "+jsstr);
            return algo;

        }
        public string Excutestring(string jsstr)
        {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            string nuevo=  (string)js.ExecuteScript("return "+jsstr);
            return nuevo;


        }
        public void AddText(String SelectorJquery, String Valor)
        {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("$('" + SelectorJquery + "').text('" + Valor + "');");

        }
        public void Click(String SelectorJquery)
        {
            IJavaScriptExecutor js;
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("$('" + SelectorJquery + "').click();");

        }
        //Fin funciones Jquery
        public String LimpiarFormatoFecha()
        {
            //Para el formato de las fotos!! en nuevas carpetas
            String DateTimeName  = DateTime.Now.ToString("(dd-MMMM-yyyy hh_mm_ss tt)").Replace("/", "");
            DateTimeName = DateTimeName.Replace(".", "");
            DateTimeName = DateTimeName.Replace(":", "");
            DateTimeName = DateTimeName.Trim();
       
            return DateTimeName;
        } 
        public String CrearDirectorioYDevolverRuta(String RutaPadre,String NombreCasoUsoID)
        {
            // Specify a name for your top-level folder.
            string folderName = RutaPadre;

            // To create a string that specifies the path to a subfolder under your 
            // top-level folder, add a name for the subfolder to folderName.
           
            string pathString = System.IO.Path.Combine(folderName, NombreCasoUsoID);
           
            System.IO.Directory.CreateDirectory(pathString);
            return pathString + @"\";

        }
        public void InicioFotos(IWebDriver driver, String Ruta, int[] width, int[] height)
        {  this.driver = driver;
             TomandoDiferentesPantallas(Ruta, width, height);
        }
         
        public void TomandoDiferentesPantallas(String Ruta, int[] width, int[] height)
        {

              List<String> Nombres =new List<String>();
              
            for (int i = 0; i < width.ToList().Count; i++)
            {
                Nombres.Add(width[i].ToString() + "X" + height[i].ToString());
                
            }
            TomarDiferenteTiposDePatallas(Ruta, width, height, Nombres);
        }
        public void TomarDiferenteTiposDePatallas(String Ruta, int[] width, int[] height,List<String> Nombres)
        {

            for (int i = 0; i < width.ToList().Count; i++)
            {
                IJavaScriptExecutor js;
                js = (IJavaScriptExecutor)driver;
            
                driver.Manage().Window.Size = new System.Drawing.Size(width[i], height[i]);
                //Solo si tiene Jquery y lo soporta!!
               // String altura= (js.ExecuteScript("return $(window).height();")).ToString();
              //  String ancho= (js.ExecuteScript("return $(window).width();")).ToString();
                System.Threading.Thread.Sleep(2000);
                String altura = "1000";
                    String ancho = "1000";
                //TomarFotoPantalla(Ruta + "Pantalla_"+Nombres[i]+"_Ventana"+ancho+"X"+altura,
                //           RutaAlterna  +"Pantalla_"+Nombres[i]+ "_Ventana"+ancho+"X"+altura);
                TomarFotoPantalla(Ruta  + "_" + ancho + "X" + altura,
                          RutaAlterna  +"_"+ancho+"X"+altura);
                }



        }
        public void TomarFotoPantalla(String Ruta, String RutaAlternativa)
        {try
            {

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
               

                if (banderarutaAlterna)
                {//Mayor calidad
                    //ss.SaveAsFile(Ruta + ".Wmf", System.Drawing.Imaging.ImageFormat.Wmf);
                    //Calidad intermedia
                  //  Screenshot ssx = ((ITakesScreenshot)driver).GetScreenshot();
                
                 //   ssx.SaveAsFile(Ruta  +".Tiff", System.Drawing.Imaging.ImageFormat.Tiff);

                   

                }else
                {//Mayor calidad
                     
                 //   ss.SaveAsFile(Ruta + ".Wmf", System.Drawing.Imaging.ImageFormat.Wmf);
                }


                //Menor calidad
                            ss.SaveAsFile(Ruta,ScreenshotImageFormat.Png);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

  
    }
}
