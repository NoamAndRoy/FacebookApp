using System;
using System.Collections.Generic;
using System.Reflection;

namespace FB
{
    public sealed class FormsRepository
    {
        private static FormsRepository s_Instance = null;

        public static FormsRepository Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new FormsRepository();
                }

                return s_Instance;
            }
        }

        private readonly Dictionary<Type, MasterForm> r_Forms = new Dictionary<Type, MasterForm>();

        private readonly Assembly r_Assembly = Assembly.GetExecutingAssembly();

        private FormsRepository()
        {
            addFormsToDictionary();
        }

        private void addFormsToDictionary()
        {
            foreach (Type type in r_Assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(MasterForm))
                    && type.IsPublic)
                {
                    this.r_Forms.Add(type, null);
                }
            }
        }

        public MasterForm this[Type i_Type]
        {
            get
            {
                MasterForm formToReturn = r_Forms[i_Type];
                if(formToReturn == null)
                {
                    formToReturn = MasterForm.CreateForm(i_Type);
                    r_Forms[i_Type] = formToReturn;
                }

                return formToReturn;
            }
        }

        public IEnumerable<Type> GetFormsTypes()
        {
            return r_Forms.Keys;
        }
    }
}