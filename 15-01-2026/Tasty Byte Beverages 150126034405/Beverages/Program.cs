using System.Linq.Expressions;

namespace Beverages  // Do not change the namespace name
{
    public class Program  // Do not change the class name
    {
        public static List<Beverage> beverageList = new List<Beverage>()
        {
            new Beverage(){ Id=1,Name="Pepsi",Cost=150,Quantity=2000},
            new Beverage(){ Id=2,Name="Maaza",Cost=120,Quantity=3000},
            new Beverage(){ Id=3,Name="RedBull",Cost=500,Quantity=2000},
            new Beverage(){ Id=4,Name="Coke",Cost=200,Quantity=2000},
            new Beverage(){ Id=5,Name="Fanta",Cost=500,Quantity=3000}
        };

        public static void Main(string[] args)  // Do not change the method signature
        {

            // Implement the code here

        }

        public static ParameterExpression variableExpr = Expression.Variable(typeof(IEnumerable<Beverage>), "sampleVar");
        public static Expression GetMyExpression(double cost)
        {

            Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(/**Copy and Paste the 'GetBeverageByCost' LINQ Query here **/));
            return assignExpr;
        }

        public static Expression GetMyExpression1(char letter)
        {

            Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(/**Copy and Paste the 'GetBeverageBySearch' LINQ Query here **/));
            return assignExpr;
        }

        public static ParameterExpression variableExpr1 = Expression.Variable(typeof(List<IGrouping<double, Beverage>>), "sampleVar");
        public static Expression GetMyExpression2()
        {

            Expression assignExpr = Expression.Assign(variableExpr1, Expression.Constant(/**Copy and Paste the 'GroupByQuantity' LINQ Query here **/));
            return assignExpr;
        }

    }
}