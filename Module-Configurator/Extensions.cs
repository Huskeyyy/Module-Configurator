using XDevkit;

namespace Module_Configurator
{
    public static class Extensions
    {
        private static readonly byte[] MemoryBuffer = new byte[32]; // Define memory buffer

        public static void WriteInt16(this IXboxConsole console, uint offset, short input)
        {
            // Convert the short input to a byte array and write it to the console memory
            BitConverter.GetBytes(input).CopyTo(MemoryBuffer, 0);
            Array.Reverse(MemoryBuffer, 0, 2);
            console.DebugTarget.SetMemory(offset, 2, MemoryBuffer, out _);
        }
    }
}
