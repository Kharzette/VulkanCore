﻿using System;
using System.Runtime.InteropServices;
using static VulkanCore.Constants;

namespace VulkanCore.Khr
{
    /// <summary>
    /// Opaque handle to a display object.
    /// </summary>
    public unsafe class DisplayKhr : VulkanHandle<long>
    {
        internal DisplayKhr(PhysicalDevice parent, long handle)
        {
            Parent = parent;
            Handle = handle;
        }

        /// <summary>
        /// Gets the parent of this resource.
        /// </summary>
        public PhysicalDevice Parent { get; }

        /// <summary>
        /// Query display supported modes.
        /// <para>Each display has one or more supported modes associated with it by default.</para>
        /// </summary>
        /// <returns>An array of <see cref="DisplayModePropertiesKhr"/> structures.</returns>
        /// <exception cref="VulkanException">Vulkan returns an error code.</exception>
        public DisplayModePropertiesKhr[] GetDisplayModeProperties()
        {
            int count;
            Result result = GetDisplayModePropertiesKhr(Parent, this, &count, null);
            VulkanException.ThrowForInvalidResult(result);

            var properties = new DisplayModePropertiesKhr[count];
            fixed (DisplayModePropertiesKhr* propertiesPtr = properties)
                result = GetDisplayModePropertiesKhr(Parent, this, &count, propertiesPtr);
            VulkanException.ThrowForInvalidResult(result);
            return properties;
        }

        [DllImport(VulkanDll, EntryPoint = "vkGetDisplayModePropertiesKHR", CallingConvention = CallConv)]
        private static extern Result GetDisplayModePropertiesKhr(
            IntPtr physicalDevice, long display, int* propertyCount, DisplayModePropertiesKhr* properties);
    }
}
