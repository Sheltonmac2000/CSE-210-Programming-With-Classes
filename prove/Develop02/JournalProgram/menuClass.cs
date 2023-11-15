public class Menu
{
    public string _menu1 = "1. Write";
    public string _menu2 = "2. Display";
    public string _menu3 = "3. Load";
    public string _menu4 = "4. Save";
    public string _menu5 = "5. Quit"; 

    public List<string> createMenuList()
    {
        List<string> menuList = new List<string>();
    
        menuList.Add(_menu1);
        menuList.Add(_menu2);
        menuList.Add(_menu3);
        menuList.Add(_menu4);
        menuList.Add(_menu5);

        // return menuList;

        foreach(string menu in menuList)
        {
            Console.WriteLine(menu);
        }

        return menuList;
    }
    

}