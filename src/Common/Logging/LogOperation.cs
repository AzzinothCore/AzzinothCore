// MIT License - Copyright (C) ryancheung and the FelCore team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System;

namespace Common
{
    public class LogOperation
    {
        public LogOperation(Logger logger, ref LogMessage msg)
        {
            _logger = logger;
            _msg = msg;
        }

        public void Call()
        {
            _logger.Write(ref _msg);
        }

        private Logger _logger;
        private LogMessage _msg;
    }
}
