////27 https://www.hackerrank.com/challenges/ctci-comparator-sorting/problem
////java


//import java.util.*;

//class Player
//{
//    String name;
//    int score;

//    Player(String name, int score)
//    {
//        this.name = name;
//        this.score = score;
//    }
//}

//class Checker implements Comparator<Player> {
//    // complete this method
//public int compare(Player a, Player b)
//{
//    int x = b.score - a.score;

//    if (x < 0)
//        return -1;
//    else if (x > 0)
//        return 1;

//    int len = Math.min(a.name.length(), b.name.length());
//    for (int i = 0; i < len; i++)
//    {
//        x = a.name.toCharArray()[i] - b.name.toCharArray()[i];
//        if (x < 0)
//            return -1;
//        else if (x > 0)
//            return 1;
//    }

//    if (b.name.length() > a.name.length())
//        return -1;
//    else if (a.name.length() > b.name.length())
//        return 1;


//    return 0;
//}
//}

