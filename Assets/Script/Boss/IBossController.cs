
using UnityEngine;
using System;

namespace GameCore.Boss
{
    public interface IBossController
    {
        void OnAttack(int attackId, Action onComplete);
        void OnMove(Vector2 dir, Action onComplete, float sec = 0);
    }
}