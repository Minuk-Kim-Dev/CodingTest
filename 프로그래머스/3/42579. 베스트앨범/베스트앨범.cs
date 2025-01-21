using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static Dictionary<string, int> genresPlay = new Dictionary<string, int>();

    public int[] solution(string[] genres, int[] plays)
    {
        List<Music> list = new List<Music>();
        List<string> addedGenres = new List<string>();
        List<int> answer = new List<int>();

        for (int i = 0; i < genres.Length; i++)
        {
            if (!genresPlay.ContainsKey(genres[i]))
                genresPlay.Add(genres[i], 0);

            genresPlay[genres[i]] += plays[i];

            Music music = new Music();
            music.genre = genres[i];
            music.play = plays[i];
            music.number = i;

            list.Add(music);
        }

        list.Sort();

        string genre;
        int count = 0;

        for(int i = 0; i < list.Count; i++)
        {
            if (!addedGenres.Contains(list[i].genre))
            {
                genre = list[i].genre;
                addedGenres.Add(list[i].genre);
            }
            else
                continue;

            for(int j = i; j < list.Count; j++)
            {
                if (count >= 2 || list[j].genre != genre)
                {
                    count = 0;
                    break;
                }

                count++;

                if (list[j].genre == genre)
                    answer.Add(list[j].number);
            }
        }

        return answer.ToArray();
    }

    class Music : IComparable
    {
        public string genre;
        public int play;
        public int number;

        public int CompareTo(object obj)
        {
            Music target = (Music)obj;

            if (genre != target.genre)
                return Solution.genresPlay[target.genre] - Solution.genresPlay[genre];

            if (play != target.play)
                return target.play - play;

            return number - target.number;
        }
    }
}