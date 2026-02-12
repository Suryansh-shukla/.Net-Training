using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDisconnArchDemo
{
    /// <summary>
    ///     Entity Class Product
    /// </summary>
    public class Product
    {
        #region Fields
        int prodId;
        string prodName;
        float price;
        string desc;
        #endregion

        #region Properties
        //CLR Properties
        public int ProdId
        {
            get { return prodId; }
            set
            {
                if (value <= 0 || value >= 999)
                {
                    throw new MyCustomException("Product ID is not between range of 0-999 seems Invalid!!!");
                }
                else
                {
                    prodId = value;
                }
            }
        }
        public string ProdName
        {
            get { return prodName; }
            set
            {
                prodName = value;
            }
        }
        public float Price
        {
            get { return price; }
            set
            {
                price = value;
            }

        }
        public string Desc
        {
            get { return desc; }
            set
            {
                desc = value;
            }
        }
        #endregion
    }
}
