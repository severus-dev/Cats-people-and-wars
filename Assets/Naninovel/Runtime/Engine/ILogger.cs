// Copyright 2022 ReWaffle LLC. All rights reserved.

namespace Naninovel
{
    public interface ILogger
    {
        void Log (string message);
        void Warn (string message);
        void Err (string message);
    }
}
