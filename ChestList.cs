namespace TotkRandomizer
{
    public static class ChestList
    {
        public static List<string> SkyIslandChestList = new List<string>()
        {
            "10765036430756727949",
            "6622572320582427780",
            "13596897972147538",
            "16214789506242704249",
            "2597875349272086117",
            "3739641094631643897",
            "12866108453194194675",
            "17495534538993137805",
            "12579209783917428061",
            "473621139589486047",
            "10920102549671158099",
            "17108513716520963657",
            "3317320439371676550",
            "9450327945854371197",
            "11627614953678724080",
            "12461254479302305629",
            "10861175834527932981",
            "17304748844865786309",
            "4626645017604891020",
            "15724262457299544102",
            "7753237306740896067",
            "1986020912273153134",
            "670814619871574662",
            "8136466365309978793",
            "16713403275151818181",
            "8773634222478081979",
            "8430896087115556560",
            "12374186808286670327",
        };

        public static Dictionary<int, string> ChestNumberList = new Dictionary<int, string>();

        public static void InitChestNumberList(int chestCount)
        {
            ChestNumberList.Clear();

            Dictionary<string, int> ChestContentsClone = new Dictionary<string, int>();
            foreach (string key in ActorList.ChestContents.Keys)
            {
                ChestContentsClone.Add(key, ActorList.ChestContents[key]);
            }

            for (int i = 0; i < chestCount; i++)
            {
                ChestContentsClone = ChestContentsClone.Shuffle();

                string newChestActor = ChestContentsClone.ElementAt(0).Key;

                ChestNumberList.Add(i, newChestActor);
                ChestContentsClone[newChestActor]--;

                if (ChestContentsClone[newChestActor] <= 0)
                {
                    ChestContentsClone.Remove(newChestActor);
                }
            }

            int aa = 0;
            foreach (int a in ActorList.ChestContents.Values)
            {
                aa += a;
            }

            //Console.WriteLine(aa);
        }
    }
}