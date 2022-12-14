namespace RedirectDecrypt
{
    public sealed class ClientConnectionPayload530 : ClientConnectionPayload
    {
        public ClientConnectionPayload530(byte[] data) : base()
        {
            Haiku = new byte[71];
            PanamaKey = new byte[32];
            PiDigits = new byte[112];

            if (data == null)
                return;

            var i = 0;
            PiDigits[9] = data[i++];
            PiDigits[79] = data[i++];
            PiDigits[5] = data[i++];
            PiDigits[11] = data[i++];
            Address[4] = data[i++];
            Hmac[6] = data[i++];
            PiDigits[65] = data[i++];
            PanamaKey[27] = data[i++];
            PiDigits[36] = data[i++];
            PiDigits[87] = data[i++];
            Hmac[13] = data[i++];
            PiDigits[73] = data[i++];
            Haiku[16] = data[i++];
            PanamaKey[21] = data[i++];
            PanamaKey[15] = data[i++];
            PanamaKey[4] = data[i++];
            Hmac[19] = data[i++];
            Haiku[58] = data[i++];
            PiDigits[92] = data[i++];
            PiDigits[104] = data[i++];
            PiDigits[50] = data[i++];
            PiDigits[81] = data[i++];
            PanamaKey[22] = data[i++];
            PiDigits[1] = data[i++];
            Haiku[11] = data[i++];
            Port |= (ushort)(((ushort)data[i++]) << 8);
            Address[2] = data[i++];
            PanamaKey[28] = data[i++];
            PiDigits[61] = data[i++];
            PiDigits[111] = data[i++];
            PiDigits[40] = data[i++];
            Address[6] = data[i++];
            Haiku[3] = data[i++];
            Haiku[61] = data[i++];
            PiDigits[27] = data[i++];
            PiDigits[80] = data[i++];
            PanamaKey[14] = data[i++];
            Haiku[13] = data[i++];
            Address[8] = data[i++];
            Hmac[16] = data[i++];
            PiDigits[47] = data[i++];
            Haiku[20] = data[i++];
            PiDigits[4] = data[i++];
            PiDigits[68] = data[i++];
            Haiku[8] = data[i++];
            PiDigits[17] = data[i++];
            PiDigits[37] = data[i++];
            Address[9] = data[i++];
            Hmac[4] = data[i++];
            Address[15] = data[i++];
            PanamaKey[19] = data[i++];
            PiDigits[44] = data[i++];
            PiDigits[107] = data[i++];
            Hmac[9] = data[i++];
            AddressType = data[i++];
            Haiku[4] = data[i++];
            Haiku[26] = data[i++];
            PiDigits[33] = data[i++];
            Haiku[33] = data[i++];
            Haiku[24] = data[i++];
            PiDigits[67] = data[i++];
            Haiku[50] = data[i++];
            Haiku[70] = data[i++];
            PiDigits[46] = data[i++];
            PiDigits[63] = data[i++];
            Haiku[60] = data[i++];
            PiDigits[59] = data[i++];
            Address[11] = data[i++];
            Hmac[8] = data[i++];
            PiDigits[52] = data[i++];
            PiDigits[51] = data[i++];
            Haiku[23] = data[i++];
            PiDigits[86] = data[i++];
            Haiku[43] = data[i++];
            Haiku[48] = data[i++];
            PanamaKey[3] = data[i++];
            PiDigits[76] = data[i++];
            Haiku[64] = data[i++];
            Haiku[25] = data[i++];
            Haiku[37] = data[i++];
            PiDigits[48] = data[i++];
            Haiku[68] = data[i++];
            Haiku[22] = data[i++];
            Haiku[30] = data[i++];
            PanamaKey[24] = data[i++];
            PiDigits[55] = data[i++];
            PiDigits[106] = data[i++];
            PiDigits[22] = data[i++];
            Haiku[15] = data[i++];
            Hmac[11] = data[i++];
            PiDigits[23] = data[i++];
            PiDigits[62] = data[i++];
            Haiku[41] = data[i++];
            PiDigits[99] = data[i++];
            PiDigits[0] = data[i++];
            Haiku[0] = data[i++];
            Haiku[38] = data[i++];
            PanamaKey[1] = data[i++];
            PanamaKey[18] = data[i++];
            Haiku[66] = data[i++];
            PiDigits[70] = data[i++];
            Address[7] = data[i++];
            PiDigits[100] = data[i++];
            Haiku[62] = data[i++];
            PiDigits[31] = data[i++];
            Haiku[47] = data[i++];
            PiDigits[75] = data[i++];
            PiDigits[89] = data[i++];
            PiDigits[26] = data[i++];
            PiDigits[25] = data[i++];
            Hmac[15] = data[i++];
            Haiku[5] = data[i++];
            PiDigits[49] = data[i++];
            PiDigits[18] = data[i++];
            PanamaKey[5] = data[i++];
            Haiku[36] = data[i++];
            PanamaKey[13] = data[i++];
            Haiku[32] = data[i++];
            PiDigits[12] = data[i++];
            Hmac[0] = data[i++];
            Hmac[1] = data[i++];
            PiDigits[38] = data[i++];
            PiDigits[53] = data[i++];
            Haiku[63] = data[i++];
            PiDigits[21] = data[i++];
            Haiku[28] = data[i++];
            PiDigits[28] = data[i++];
            Haiku[52] = data[i++];
            Haiku[17] = data[i++];
            PiDigits[71] = data[i++];
            PiDigits[110] = data[i++];
            PiDigits[90] = data[i++];
            PanamaKey[0] = data[i++];
            Haiku[10] = data[i++];
            Haiku[44] = data[i++];
            Haiku[19] = data[i++];
            PiDigits[29] = data[i++];
            PanamaKey[9] = data[i++];
            Haiku[56] = data[i++];
            PiDigits[72] = data[i++];
            PiDigits[56] = data[i++];
            PanamaKey[16] = data[i++];
            PiDigits[16] = data[i++];
            PanamaKey[25] = data[i++];
            Haiku[51] = data[i++];
            PiDigits[85] = data[i++];
            Haiku[45] = data[i++];
            Haiku[18] = data[i++];
            PanamaKey[31] = data[i++];
            Hmac[10] = data[i++];
            PiDigits[57] = data[i++];
            Haiku[40] = data[i++];
            PiDigits[101] = data[i++];
            PiDigits[3] = data[i++];
            Haiku[21] = data[i++];
            PiDigits[60] = data[i++];
            Haiku[59] = data[i++];
            PiDigits[69] = data[i++];
            Haiku[6] = data[i++];
            Haiku[29] = data[i++];
            XorMagic = data[i++];
            PiDigits[8] = data[i++];
            PiDigits[103] = data[i++];
            Port |= data[i++];
            Haiku[34] = data[i++];
            PiDigits[42] = data[i++];
            PanamaKey[12] = data[i++];
            PanamaKey[6] = data[i++];
            Hmac[7] = data[i++];
            PiDigits[32] = data[i++];
            PiDigits[45] = data[i++];
            PiDigits[6] = data[i++];
            PiDigits[82] = data[i++];
            Hmac[17] = data[i++];
            Hmac[12] = data[i++];
            PanamaKey[20] = data[i++];
            Haiku[49] = data[i++];
            Address[3] = data[i++];
            Address[10] = data[i++];
            PanamaKey[26] = data[i++];
            PiDigits[39] = data[i++];
            Address[12] = data[i++];
            PanamaKey[11] = data[i++];
            PiDigits[13] = data[i++];
            Haiku[65] = data[i++];
            PiDigits[7] = data[i++];
            PiDigits[93] = data[i++];
            PiDigits[102] = data[i++];
            PiDigits[78] = data[i++];
            PiDigits[84] = data[i++];
            PiDigits[91] = data[i++];
            PanamaKey[8] = data[i++];
            Haiku[67] = data[i++];
            PiDigits[15] = data[i++];
            PiDigits[10] = data[i++];
            Haiku[12] = data[i++];
            Hmac[2] = data[i++];
            PiDigits[95] = data[i++];
            Haiku[57] = data[i++];
            PiDigits[96] = data[i++];
            PiDigits[77] = data[i++];
            PiDigits[30] = data[i++];
            Haiku[46] = data[i++];
            Haiku[1] = data[i++];
            Haiku[42] = data[i++];
            Haiku[27] = data[i++];
            PiDigits[34] = data[i++];
            PiDigits[108] = data[i++];
            PanamaKey[7] = data[i++];
            PiDigits[66] = data[i++];
            PanamaKey[23] = data[i++];
            Address[5] = data[i++];
            PiDigits[74] = data[i++];
            Hmac[18] = data[i++];
            PiDigits[98] = data[i++];
            Address[1] = data[i++];
            PiDigits[14] = data[i++];
            Haiku[14] = data[i++];
            Address[14] = data[i++];
            PiDigits[64] = data[i++];
            Haiku[9] = data[i++];
            Haiku[2] = data[i++];
            PiDigits[2] = data[i++];
            PiDigits[83] = data[i++];
            Haiku[54] = data[i++];
            PiDigits[105] = data[i++];
            PiDigits[43] = data[i++];
            PiDigits[24] = data[i++];
            Haiku[69] = data[i++];
            PiDigits[94] = data[i++];
            PiDigits[19] = data[i++];
            PiDigits[54] = data[i++];
            PanamaKey[2] = data[i++];
            Hmac[14] = data[i++];
            PanamaKey[17] = data[i++];
            PiDigits[58] = data[i++];
            Hmac[5] = data[i++];
            PiDigits[20] = data[i++];
            PiDigits[35] = data[i++];
            Address[13] = data[i++];
            Haiku[31] = data[i++];
            Haiku[7] = data[i++];
            Haiku[35] = data[i++];
            PiDigits[41] = data[i++];
            Address[0] = data[i++];
            PiDigits[97] = data[i++];
            PanamaKey[10] = data[i++];
            PiDigits[88] = data[i++];
            Haiku[39] = data[i++];
            Hmac[3] = data[i++];
            PanamaKey[30] = data[i++];
            PiDigits[109] = data[i++];
            PanamaKey[29] = data[i++];
            Haiku[53] = data[i++];
            Haiku[55] = data[i++];
        }
    }
}
