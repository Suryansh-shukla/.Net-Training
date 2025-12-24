using System;
namespace ConsoleApp1
{
    public interface IAdd
    {
        int AddMe(int a, int b);
    }

    public interface ISubtract
    {
        int SubMe(int a, int b);
    }

    public interface IMultiply
    {
        int ProdMe(int a, int b);
    }

    public interface IDivide
    {
        int DivMe(int a, int b);
    }

    public interface IAddSub: IAdd, ISubtract
    {
    }
    public interface IAddProdDiv: IAdd, IMultiply, IDivide
    {
    }
    public interface IAll: IAdd, ISubtract, IMultiply, IDivide
    {
    }
}