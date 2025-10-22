﻿using Stockfish.NET.Models;
using System;

namespace Stockfish.NET
{
    public interface IStockfish : IDisposable
    {
        int Depth { get; set; }
        int SkillLevel { get; set; }
        void SetPosition(params string[] move);
        string GetBoardVisual();
        string GetFenPosition();
        void SetFenPosition(string fenPosition);
        string GetBestMove();
        string GetBestMoveTime(int time = 1000);
        bool IsMoveCorrect(string moveValue);
        Evaluation GetEvaluation();
    }
}