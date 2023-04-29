using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.XMP.Options;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Document = iText.Layout.Document;

namespace Infra.DataAccess.Repositories
{
    public class Reportes : MasterRepository
    {
        public Reportes()
        {
            
        }

        public void GenerarReporte(string opcion)
        {
            ////////////////////////
            /*
             PdfPTable tblEncabezado = new PdfPTable(2);
            tblEncabezado.WidthPercentage = 100;
            tblEncabezado.TotalWidth = 500f;
            float[] widths = new float[] { 363f, 137f };
            tblEncabezado.SetWidths(widths);
            var celda = new PdfPCell();
            Font AvenirNegroSmall = FontFactory.GetFont("Avenir", 7f, Font.NORMAL, new BaseColor(60, 60, 59));

            string text = @"Nota: El presente certificado tiene una vigencia de 30 días y se emite a efectos de ser presentado ante las autoridades de la República de Honduras. Este documento consta de 1 hoja con 1 producto y no debe contener enmiendas, tachaduras, modificaciones o superposiciones.";
            celda = new PdfPCell(new Paragraph("\n\n\n" + text, AvenirNegroSmall));
            celda.Border = Rectangle.NO_BORDER;
            celda.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            celda.VerticalAlignment = PdfPCell.ALIGN_BOTTOM;
            celda.Colspan = 2;
            tblEncabezado.AddCell(celda);
            document.Add(tblEncabezado);
             */
            ///////////////////////

            // ENCABEZADO
            Table tblEncabezado = new Table(new float[] { 415f, 85f });
            //Table tblEncabezado = new Table(new UnitValue[] { new UnitValue(UnitValue.PERCENT, 75f), new UnitValue(UnitValue.PERCENT, 25f) });
            tblEncabezado.SetWidth(UnitValue.CreatePercentValue(100));
            tblEncabezado.SetMarginTop(20);

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:\\Users\\Billy Mejia\\Desktop\\logo\\Logotipo.png")).SetWidth(45).SetHeight(50);
            var plogo = new Paragraph("").Add(logo);//.Add(logo);

            var titulo = new Paragraph("Reporte de " + opcion);
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            Cell cell1 = new Cell().Add(new Paragraph("").Add(plogo));
            Cell cell2 = new Cell().Add(fecha);
            cell2.SetTextAlignment(TextAlignment.JUSTIFIED_ALL);

            tblEncabezado.AddCell(cell1.SetBorder(Border.NO_BORDER));
            tblEncabezado.AddCell(cell2.SetBorder(Border.NO_BORDER));
            tblEncabezado.SetBorder(Border.NO_BORDER);

            //Linea
            LineSeparator separador1 = new LineSeparator(new SolidLine(1f));
            separador1.SetMarginBottom(15);

            LineSeparator separador2 = new LineSeparator(new SolidLine(1f));
            separador2.SetMarginTop(15);

            // PIE DE PAGINA
            Table tblPieDePagina = new Table(new float[] { 363f, 137f });
            tblPieDePagina.SetWidth(UnitValue.CreatePercentValue(100));

            string text = "Desarrollado por G.E.I.J";
            //Cell cell3 = new Cell().Add(new Paragraph("Pagina 1 de 1"));
            Cell cell4 = new Cell().Add(new Paragraph(text));
            //cell3.SetBorder(Border.NO_BORDER);
            //cell3.SetTextAlignment(TextAlignment.LEFT);
            //cell3.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            //cell3.SetVerticalAlignment(VerticalAlignment.BOTTOM);
            //tblPieDePagina.AddCell(cell3);

            cell4.SetBorder(Border.NO_BORDER);
            //cell4.SetTextAlignment(TextAlignment.RIGHT);
            cell4.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            cell4.SetVerticalAlignment(VerticalAlignment.BOTTOM);
            tblPieDePagina.AddCell(cell4);

            PdfWriter pdfWriter = new PdfWriter("C:\\Users\\Billy Mejia\\Desktop\\Reportes"+opcion+".pdf");//Ruta donde se creará el PDF
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize pageSize = PageSize.A4.Rotate(); // establece el tamaño de la página en horizontal
            pdf.SetDefaultPageSize(pageSize);


            Document documento = new Document(pdf);//Tamaño de hoja

            documento.SetMargins(10, 20, 55, 20); //up, right, bottom, left

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            //PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            //string[] columnas = { "Id", "Nombre Usuario", "Contraseña", "Nombre", "Apellido", "Posicion", "Correo", "Foto" };
            float[] tamanios = { 1, 3, 3, 3, 3, 3, 4, 2 };//Dimension de cada celda

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            string sql = "select * from " + opcion;

            var table = ExecuteReader(sql,CommandType.Text);

            foreach (DataColumn columna in table.Columns)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna.ColumnName).SetFont(fontColumnas)));
            }

            foreach (DataRow fila in table.Rows)
            {
                foreach (DataColumn columna in table.Columns)
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(fila[columna].ToString())));
                }
            }

            tabla.SetTextAlignment(TextAlignment.CENTER);

            documento.Add(tblEncabezado);
            documento.Add(separador1);
            documento.Add(titulo);
            documento.Add(tabla);
            documento.Add(separador2);
            documento.Add(tblPieDePagina);

            documento.Close();
        }
    }
}
