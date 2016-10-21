﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTreeManager.CodeStructures
{
    [ProtoContract(SkipConstructor = true)]
    [ProtoInclude(1, typeof(Assignation))]
    [ProtoInclude(2, typeof(CodeBlock))]
    [ProtoInclude(3, typeof(CodeValue))]
    [ProtoInclude(4, typeof(Comment))]
    public interface ICodeStruct
    {
        string Parse();
        void Analyse(string code);
        ICodeStruct FindValue(string TagToFind);
        ICodeStruct FindAssignation(string TagToFind);
        List<ICodeStruct> FindAllValuesOfType<T>(string TagToFind);
    }
}
