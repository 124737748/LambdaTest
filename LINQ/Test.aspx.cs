using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class Test : System.Web.UI.Page
    {
        Countries[] cc=new Countries[10];
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int ctr = 0; ctr < cc.Length; ctr++)
            {
                cc[ctr] = new Countries();
            }
            cc[0].Country = "Bangladesh";
            cc[0].Population = 156594962;
            cc[0].Continent = "Asia";
            cc[1].Country = "Brazil";
            cc[1].Population = 200361925;
            cc[1].Continent = "America";
            cc[2].Country = "China";
            cc[2].Population = 1357380000;
            cc[2].Continent = "Asia";
            cc[3].Country = "India";
            cc[3].Population = 1252139596;
            cc[3].Continent = "Asia";
            cc[4].Country = "Indonesia";
            cc[4].Population = 249865631;
            cc[4].Continent = "Asia";
            cc[5].Country = "Japan";
            cc[5].Population = 127338621;
            cc[5].Continent = "Asia";
            cc[6].Country = "Nigeria";
            cc[6].Population = 173615345;
            cc[6].Continent = "Africa";
            cc[7].Country = "Pakistan";
            cc[7].Population = 182142594;
            cc[7].Continent = "Asia";
            cc[8].Country = "Russian Federation";
            cc[8].Population = 143499861;
            cc[8].Continent = "Europe";
            cc[9].Country = "United States";
            cc[9].Population = 316128839;
            cc[9].Continent = "America";
            btnDisplay_Click(sender, e);
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Label2.Text = "Alphabetical List";
            var info = from i in cc select i;
            GridView1.DataSource = info;
            GridView1.DataBind();
        }

        protected void btnGroup_Click(object sender, EventArgs e)
        {
            Label2.Text = "Continent Wise Group Data";
            var info = from i in cc
                       orderby i.Continent
                       group i by i.Continent into g
                       select new
                       {
                           Continent = g.Key,
                           NumberOfCountries = g.Count(),
                           TotalPopulation = g.Sum(s => s.Population),
                           AveragePopulation = g.Average(a => a.Population)
                       };
            GridView1.DataSource = info;
            GridView1.DataBind();
        }

        protected void btnAsc_Click(object sender, EventArgs e)
        {
            Label2.Text = "In Ascending Order of Population";
            var info = from i in cc orderby i.Population select i;
            GridView1.DataSource = info;
            GridView1.DataBind();
        }

        protected void btnDesc_Click(object sender, EventArgs e)
        {
            Label2.Text = "In Descending Order of Population";
            var info = from i in cc orderby i.Population descending select i;
            GridView1.DataSource = info;
            GridView1.DataBind();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Label2.Text = "Data Filtered by Country Name";
            var info = from i in cc 
                       where i.Country.ToUpper().Contains(txtCountry.Text.Trim().ToUpper())
                       select i;
            GridView1.DataSource = info;
            GridView1.DataBind();
        }
    }

    public class Countries
    {
        public string Country
        {
            get;
            set;
        }
        public long Population
        {
            get;
            set;
        }
        public string Continent
        {
            get;
            set;
        }
    }
}