using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    internal class ImageFile
    {
        private string _path;
        private Image _image;
        private PropertyItem[] _properties;
        private List<string> _results;

        public string Path { get { return _path; } set { _path = value; } }
        public Image Image { get { return _image; } set { _image = value; } }
        public PropertyItem[] Properties { get { return _properties; } set { _properties = value; } }
        public List<string> Results { get { return _results; } }

        public ImageFile(string path)
        {
            _path = path;
            Image _image = null;
            PropertyItem[] _properties = null;
            _results = new List<string>();
        }

        public void extractData()
        {
            Image = new Bitmap($@"{Path}");
            Properties = Image.PropertyItems;
            ASCIIEncoding encoding = new ASCIIEncoding();

            foreach (var property in Properties)
            {
                Results.Add(encoding.GetString(property.Value));
            }
        }
    }
}
