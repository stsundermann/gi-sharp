using System;
using System.Collections.Generic;

namespace Generator
{
    public class SymbolTable
    {
        private Dictionary<string, IType> TypeTable = new Dictionary<string, IType>();

        public SymbolTable()
        {
            Add(new Primitive("gint", "int", "0"));
            Add(new Primitive("guint", "uint", "0"));
            
            Add(new Primitive("gint8", "sbyte", "0"));
            Add(new Primitive("guint8", "byte", "0"));
            
            Add(new Primitive("gint16", "short", "0"));
            Add(new Primitive("guint16", "ushort", "0"));

            Add(new Primitive("gint32", "int", "0"));
            Add(new Primitive("guint32", "uint", "0"));
            
            Add(new Primitive("gint64", "long", "0"));
            Add(new Primitive("guint64", "ulong", "0"));
            
            Add(new Primitive("glong", "long", "0"));
            Add(new Primitive("gulong", "ulong", "0"));
            
            Add(new Primitive("gchar", "sbyte", "0"));
            Add(new Primitive("guchar", "byte", "0"));
            
            Add(new Primitive("gshort", "short", "0"));
            Add(new Primitive("gushort", "ushort", "0"));
            
            Add(new Primitive("gfloat", "float", "0"));
            Add(new Primitive("gdouble", "double", "0"));

            Add(new Primitive("gboolean", "bool", "false"));
            
            Add(new Primitive("gpointer", "IntPtr", "IntPtr.Zero"));
            Add(new Primitive("gconstpointer", "IntPtr", "IntPtr.Zero"));
            Add(new Primitive("gupointer", "UIntPtr", "UIntPtr.Zero"));
            
            Add(new Primitive("gsize", "UIntPtr", "UIntPtr.Zero"));
        }
        
        public void Add(IType type)
        {
            TypeTable[type.CType] = type;
        }
    }
}