/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/06/18 14:04:14
** desc:  顺序执行节点;
*********************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    public class BTSequence : AbsBehavior
    {
        private List<AbsBehavior> _list = new List<AbsBehavior>();

        public BTSequence(object[] args) : base(args) { }

        protected override void AwakeEx()
        {
            throw new System.NotImplementedException();
        }

        protected override void Reset()
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateEx()
        {
            throw new System.NotImplementedException();
        }
    }
}