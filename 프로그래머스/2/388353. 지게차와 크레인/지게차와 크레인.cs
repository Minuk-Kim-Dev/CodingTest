using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] storage, string[] requests) {
        int n = storage.Length;
        int m = storage[0].Length;

        char[,] grid = new char[n + 2, m + 2];
        for (int i = 0; i < n + 2; i++) {
            for (int j = 0; j < m + 2; j++) {
                if (i == 0 || j == 0 || i == n + 1 || j == m + 1) {
                    grid[i, j] = '.';
                } else {
                    grid[i, j] = storage[i - 1][j - 1];
                }
            }
        }

        int[] dx = { 1, -1, 0, 0 };
        int[] dy = { 0, 0, 1, -1 };

        foreach (var req in requests) {
            char target = req[0];

            if (req.Length == 1) {
                bool[,] visited = new bool[n + 2, m + 2];
                Queue<(int, int)> q = new Queue<(int, int)>();
                q.Enqueue((0, 0));
                visited[0, 0] = true;

                while (q.Count > 0) {
                    var (x, y) = q.Dequeue();

                    for (int dir = 0; dir < 4; dir++) {
                        int nx = x + dx[dir];
                        int ny = y + dy[dir];

                        if (nx < 0 || ny < 0 || nx >= n + 2 || ny >= m + 2) continue;
                        if (visited[nx, ny]) continue;

                        visited[nx, ny] = true;

                        if (grid[nx, ny] == target)
                            grid[nx, ny] = '.';
                        else if (grid[nx, ny] == '.')
                            q.Enqueue((nx, ny));
                    }
                }
            } else {
                // 크레인 모드
                for (int i = 1; i <= n; i++) {
                    for (int j = 1; j <= m; j++) {
                        if (grid[i, j] == target) {
                            grid[i, j] = '.';
                        }
                    }
                }
            }
        }

        int answer = 0;
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= m; j++) {
                if (grid[i, j] != '.') answer++;
            }
        }

        return answer;
    }
}
