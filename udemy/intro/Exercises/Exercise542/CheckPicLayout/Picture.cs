
public struct Picture
{
    public float width, length;
    public string layout;

    public Picture(float w, float l)
    {
        width = w;
        length = l;
        layout = GetLayout(w, l);
        
    }

    private static string GetLayout(float width, float length)
    {
        float ratio = length / width;
        string result;
        if (ratio < 1f)
        {
            result = "portrait";
        }
        else
        {
            result = "landscape";
        }

        return result;
    }
}