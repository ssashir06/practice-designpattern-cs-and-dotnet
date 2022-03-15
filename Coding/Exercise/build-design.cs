using System;
using System.Text;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Code {
        private int indentCount = 2;
        public readonly string name;
        public readonly List<CodeField> fields = new List<CodeField>();
        public Code(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {name}");
            sb.AppendLine("{");
            foreach (var i in fields) {
                sb.Append(new string(' ', indentCount));
                sb.AppendLine(i.ToString());
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
    public class CodeField {
        public readonly string type;
        public readonly string name;
        public CodeField(string type, string name)
        {
            this.type = type;
            this.name = name;
        }
        public override string ToString()
        {
            return $"public {type} {name};";
        }
    }
    public class CodeBuilder
    {
        private readonly Code code;

        public CodeBuilder(string name)
        {
            code = new Code(name);
        }

        public CodeBuilder AddField(string name, string type)
        {
            code.fields.Add(new CodeField(type, name));
            return this;
        }

        public override string ToString()
        {
            return code.ToString();
        }
    }

}
