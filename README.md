# Absolute Permutation Challenge

A Console Application solving the Absolute Permutation Problem.

We define `P` to be a permutation of the first `n` natural numbers in the range `[1, n]`. Let `pos[i]` denote the value at position `i` in permutation `P` using 1-based indexing.

`P` is considered to be an absolute permutation if `|pos[i] - i| = k` holds true for every `i E [1, n]`.

Given `n` and `k`, print the lexicographically smallest absolute permutation `P`. If no absolute permutation exists, print -1.

For example, let `n = 4` giving us an array `pos = [1, 2, 3, 4]`. If we use 1-based indexing, create a permutation where every `|pos[i] - 1| = k`. If `k = 2`, we could rearrange them to `[3, 4, 1, 2]`.

More details at [HackerRank](https://www.hackerrank.com/challenges/absolute-permutation/problem).