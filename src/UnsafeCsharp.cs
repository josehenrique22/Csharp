
using System;
using System.Runtime.InteropServices;

namespace LowLevel {

    struct ExStruct {
        public int X;
        public int Y;

        // Constructor 
        public ExStruct(int x, int y) {
            X = x;
            Y = y;
        }

        public void Show() {
            Console.WriteLine($"ExStruct: ({X}, {Y})");
        }
    }

    public class LearnLowLevel {

        // Simple way to free memory
        public unsafe void AllocMemoryMethodEx() 
        {
            // Alloc Memory
            int* ptr = (int*)Marshal.AllocHGlobal(sizeof(int));

            // Value to memory Allocated
            *ptr = 43;

            Console.WriteLine($"Value Allocated is: {*ptr}");

            Marshal.FreeHGlobal((IntPtr)ptr);
        }

        // More modern way
        public unsafe void ModernAllocMemoryEx() 
        {   
            // Alloc 1 byte of memory for a int
            IntPtr ptr = (nint)NativeMemory.Alloc(sizeof(int));

            // Give the memory allocated a value
            Marshal.WriteInt32(ptr, 4);

            // read value
            int value = Marshal.ReadInt32(ptr);
            Console.WriteLine($"Value Allocated: {value}");

            // free memory allocated
            NativeMemory.Free((void*)ptr);

        }
        
        // Alloc in the stack
        public unsafe void StackAllocMemory() 
        {
            int* ptr = stackalloc int[10];

            // Value
            for (int i = 0; i < 10; i++)
            {
                ptr[i] = i * 10;
            }

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(ptr[i]);
            }

            // When the method finish the memory is automatic free
        }
    }
}