using System;
using System.Collections.Generic;

namespace PA.Model
{
    public class Password
    {
        private DateTime startRecordingPassword;
        private List<PasswordPart> PasswordParts { get; set; }
        private static int maxSize { get; set; }

        public Password()
        {
            PasswordParts = new List<PasswordPart>();
        }

         static Password()
        {
            maxSize = 100;
        }

        public void AddPart(PasswordPart pPart)
        {
            if (PasswordParts.Count == maxSize)
            {
                throw new ArgumentException("Maximum password length reached.");
            }
            if (PasswordParts.Count == 0)
            {
                startRecordingPassword = DateTime.Now;
                pPart.ActionTime = TimeSpan.Zero;
            }
            else
            {
                pPart.ActionTime = DateTime.Now - startRecordingPassword;
            }
            PasswordParts.Add(pPart);
        }

        public static bool operator ==(Password a, Password b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }
            
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            if ((object) a.PasswordParts == null || (object) b.PasswordParts == null)
            {
                return false;
            }
            if (a.PasswordParts.Count != b.PasswordParts.Count)
            {
                return false;
            }

            for (int i = 0; i < a.PasswordParts.Count; i++)
            {
                if (a.PasswordParts[i] != b.PasswordParts[i])
                {
                    return false;
                }
            }
            return true;
            //return a.PasswordParts.SequenceEqual(b.PasswordParts);
        }

        public static bool operator !=(Password a, Password b)
        {
            return !(a == b);
        }

    }
}
