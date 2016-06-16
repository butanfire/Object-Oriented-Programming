namespace WordDocument
{
    using Novacode;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class WordDocGenerator
    {
        public static void Main()
        {
            string imageName = @"image.JPG";
            string filename = @"C:\DocOutput.docx";
            var doc = DocX.Create(filename);
            doc.PageWidth = 740;
            doc.MarginRight = 120;

            Paragraph par0 = doc.InsertParagraph();
            par0.Append("SoftUni OOP Game Contest").Color(Color.Black).Bold().FontSize(23); //insert the intro title
            par0.Alignment = Alignment.center;

            Paragraph par1 = doc.InsertParagraph(); //the main paragraph
            System.Drawing.Image myImg = System.Drawing.Image.FromFile(imageName); //extract the image from the file
            Novacode.Image img = doc.AddImage(imageName); // Create image.
            Picture pic1 = img.CreatePicture();     // Create picture.
            par1.InsertPicture(pic1); // append the picture

            par1.Append(" ");
            par1.AppendLine("SoftUni is organizing a contest for the best").Append(" role playing game ").Bold().Append("from the OOP teamwork projects. The winning team will receive a ").Append("grand prize").Bold().UnderlineColor(System.Drawing.Color.Black).Append("!");
            par1.AppendLine("The game should be :");
            par1.Alignment = Alignment.both;            

            var list = doc.AddList(null, 0, ListItemType.Bulleted); //adding the bullet list
            
            doc.AddListItem(list, "Properly structured and follow all good OOP practices", 0); //adding the bullet items
            doc.AddListItem(list, "Awesome", 0);
            doc.AddListItem(list, "..Very Awesome", 0);
            doc.InsertList(list);

            doc.InsertParagraph().Append(" ");

            Table tableInfo = doc.InsertTable(4, 3); //creating the table
            tableInfo.Design = TableDesign.TableGrid; //set the design - to look better
            tableInfo.Alignment = Alignment.left; //aligning the table
            tableInfo.AutoFit = AutoFit.Window;  //resizing (although not working as expected)
            float[] widthRanges = { 150, 210, 130 }; //setting the columns sizes, for each
            tableInfo.SetWidths(widthRanges);

            List<Cell> topCells = tableInfo.Rows.First().Cells; //modify the first row of cells
            string output = "";
            for (int i = 0; i < 3; i++) //iterate through the 3 cells
            {
                topCells[i].FillColor = Color.DeepSkyBlue;
                if (i == 0)
                {
                    output = "Team";
                }
                if (i == 1)
                {
                    output = "Game";
                }
                if (i == 2)
                {
                    output = "Points";
                }

                Paragraph inside = topCells[i].InsertParagraph();
                inside.Append(output).Color(Color.White);
                inside.Alignment = Alignment.center;
            }
            
            for (int i = 1; i < 4; i++) //the rest of the cells, where we have to write '-'
            {
                foreach (var cell in tableInfo.Rows[i].Cells) //iterate the cell for each row
                {
                    Paragraph tempCell = cell.InsertParagraph().Append("-").Color(Color.Black);
                    tempCell.Alignment = Alignment.center;
                }
            }
            
            Paragraph par2 = doc.InsertParagraph(); //last entries at the bottom
            par2.AppendLine("The top 3 teams will receive a ").Append("SPECTACULAR").FontSize(12).Bold().Append(" prize :");
            par2.AppendLine("A HANDSHAKE FROM NAKOV").UnderlineColor(System.Drawing.Color.DarkBlue).FontSize(22).Bold().Color(System.Drawing.Color.DarkBlue);
            par2.Alignment = Alignment.center;
            par2.AppendLine(" ");
            par2.AppendLine(new string('_',200)).FontSize(4);
            doc.Save();
        }
    }
}
