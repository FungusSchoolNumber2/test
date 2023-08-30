namespace Test1;

public class Water
{
    private Random RNG = new Random();
    public List<List<bool>> area = new List<List<bool>>();
    private List<string> cords = new List<string>();

    public int _areaSize;

    //ctor 
    public Water(int areaSize, int ships, bool bot)
    {
        _areaSize = areaSize;
        for (int i = 0; i < _areaSize; i++)
        {
            area.Add(new List<bool>());
        }

        foreach (List<bool> list in area)
        {
            for (int i = 0; i < _areaSize; i++)
            { 
                list.Add(false);   
            }
        }

        if (bot)
        {
            for (int i = 0; i < ships; i++)
            {
                MakeCords();
            }
        }
        cordsToList();

        foreach (string cord in cords)
        {
            Console.WriteLine(cord);
        }
    }

    private void MakeCords()
    {
        bool run = true;
        while (run)
        {
            bool wors = true;

            int cord1 = RNG.Next(_areaSize);
            int cord2 = RNG.Next(_areaSize);

            string newCord = cord1.ToString() + "," + cord2.ToString();
            foreach (string cord in cords)
            {
                if (newCord == cord)
                {
                    wors = false;
                }
            }

            if (wors == true)
            {
                cords.Add(newCord);
                run = false;
            }
        }
    }

    private void cordsToList()
    {
        foreach (string cord in cords)
        {
            string[] split = cord.Split(',');
            area[int.Parse(split[0])][int.Parse(split[1])] = true;
        }
    }

    public void drawGrid()
    {
        foreach (List<bool> list in area)
        {
            foreach (bool ship in list)
            {
                Console.Write(ship.ToString());
            }

            Console.WriteLine();
        }
    }
}