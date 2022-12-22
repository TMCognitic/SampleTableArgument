using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

var produits = new[] { new { ProduitId = 1, Quantite = 5 }, new { ProduitId = 2, Quantite = 15 } };


using (DbConnection dbConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SampleTableArgument;Integrated Security=True;"))
{
    using(DbCommand dbCommand = dbConnection.CreateCommand())
    {
        dbCommand.CommandText = "CSP_AddCommand";
        dbCommand.CommandType = CommandType.StoredProcedure;

        DataTable produitsParameter = new DataTable();
        produitsParameter.Columns.Add("ProduitId", typeof(long));
        produitsParameter.Columns.Add("Quantite", typeof(int));

        foreach(var produit in produits)
        {
            produitsParameter.Rows.Add(produit.ProduitId, produit.Quantite);
        }

        DbParameter dbParameter = dbCommand.CreateParameter();
        dbParameter.ParameterName = "Details";
        dbParameter.Value = produitsParameter;

        dbCommand.Parameters.Add(dbParameter);

        dbConnection.Open();
        dbCommand.ExecuteNonQuery();
    }
}