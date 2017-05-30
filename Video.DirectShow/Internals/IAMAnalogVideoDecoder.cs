
namespace AForge.Video.DirectShow.Internals
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The IAMAnalogVideoDecoder interfacesets and retrieves information about 
    /// the analog-to-digital conversion process in a video capture filter.
    /// </summary>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
     Guid("C6E13350-30AC-11d0-A18C-00A0C9118956"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAMAnalogVideoDecoder
    {
        /// <summary>
        /// Retrieves the analog video formats that the decoder supports.
        /// </summary>
        /// <param name="lAnalogVideoStandard">Pointer to a variable that receives a bitwise OR
        /// of zero or more flags from the AnalogVideoStandard enumeration.</param>
        /// <returns>>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int get_AvailableTVFormats([Out] out AnalogVideoStandard lAnalogVideoStandard);

        /// <summary>
        /// Sets the analog video format.
        /// </summary>
        /// <param name="lAnalogVideoStandard">Specifies the video format as a member of the AnalogVideoStandard enumeration.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int put_TVFormat([In] AnalogVideoStandard lAnalogVideoStandard);

        /// <summary>
        /// Retrieves the current analog video format.
        /// </summary>
        /// <param name="plAnalogVideoStandard">Pointer to a variable that receives a member of the AnalogVideoStandard 
        /// enumeration, indicating the analog video format.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int get_TVFormat([Out] out AnalogVideoStandard plAnalogVideoStandard);

        /// <summary>
        /// Determines whether the horizontal sync is locked.
        /// </summary>
        /// <param name="plLocked">Pointer to a variable that receives one of the following values.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int get_HorizontalLocked([Out, MarshalAs(UnmanagedType.Bool)] out bool plLocked);

        /// <summary>
        /// Specifies whether the video is a tape source or a broadcast source.
        /// </summary>
        /// <param name="lVCRHorizontalLocking">Specifies one of the following values.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int put_VCRHorizontalLocking([In, MarshalAs(UnmanagedType.Bool)] bool lVCRHorizontalLocking);

        /// <summary>
        /// Indicates whether the decoder is expecting video from a tape source or a broadcast source
        /// </summary>
        /// <param name="plVCRHorizontalLocking">Pointer to a variable that receives one of the following values.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int get_VCRHorizontalLocking([Out, MarshalAs(UnmanagedType.Bool)] out bool plVCRHorizontalLocking);

        /// <summary>
        /// Retrieves the number of scan lines in the video signal.
        /// </summary>
        /// <param name="plNumberOfLines">Pointer to a variable that receives the number of scan lines in the video signal.
        /// This is generally by 525 lines for NTSC and 625 lines for PAL or SECAM.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int get_NumberOfLines([Out] out int plNumberOfLines);

        /// <summary>
        /// Enables or disables the video port bus.
        /// </summary>
        /// <param name="lOutputEnable">Specifies whether the bus is enabled. Use one of the following values.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int put_OutputEnable([In, MarshalAs(UnmanagedType.Bool)] bool lOutputEnable);

        /// <summary>
        /// Determines whether the video port bus is enabled.
        /// </summary>
        /// <param name="plOutputEnable">Pointer to a variable that receives one of the following values.</param>
        /// <returns>Return's <b>HRESULT</b> error code</returns>
        [PreserveSig]
        int get_OutputEnable([Out, MarshalAs(UnmanagedType.Bool)] out bool plOutputEnable);
    }
}
