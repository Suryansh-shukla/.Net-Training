namespace day6demo3;

public class HeightCategory
{
    public int heightCM;
    public string GetHeightCategory()
    {
        if (heightCM < 150)
        {
            return "Short";
        }
        else if (heightCM >= 150 && heightCM <180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }
}
