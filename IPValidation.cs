namespace FirstProject
{
    internal class IPValidation
    {
        public static bool IsValidIp(string ipAddres)
        {
            var lstOCeans = ipAddres.Split('.');
            if (lstOCeans.Length != 4) { return false; }
            foreach (var oceans in lstOCeans)
            {
                if (oceans == null) return false;
                var symbInOceans = oceans.ToCharArray();
                if (symbInOceans.Length == 0 || symbInOceans.Length > 3) return false;
                if (symbInOceans[0] == '0' && symbInOceans.Length > 1) return false;
                foreach (char symb in symbInOceans)
                {
                    if (!char.IsDigit(symb))
                        return false;
                }
                if (int.Parse(oceans) > 255 || int.Parse(oceans) < 0) return false;
            }

            return true;
        }
    }
}
