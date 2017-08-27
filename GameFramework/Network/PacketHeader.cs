﻿//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2017 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

namespace GameFramework.Network
{
    /// <summary>
    /// 网络消息包头基类。
    /// </summary>
    public abstract class PacketHeader
    {
        /// <summary>
        /// 获取网络消息包长度。
        /// </summary>
        public int PacketLength
        {
            get;
        }
    }
}