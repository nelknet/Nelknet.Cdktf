namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamVirtualMfaDeviceState<'VirtualMfaDeviceName> = { assignments: ResizeArray<aws.IamVirtualMfaDevice.IamVirtualMfaDeviceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_virtual_mfa_device">aws_iam_virtual_mfa_device</a>.
    /// </summary>
    type IamVirtualMfaDeviceBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamVirtualMfaDeviceState<Missing> =
            ({ assignments = ResizeArray() } : IamVirtualMfaDeviceState<Missing>)

        member _.Zero(()) : IamVirtualMfaDeviceState<Missing> =
            ({ assignments = ResizeArray() } : IamVirtualMfaDeviceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_virtual_mfa_device#virtual_mfa_device_name-1">IamVirtualMfaDevice#virtual_mfa_device_name</a>.
        /// </summary>
        [<CustomOperation "virtual_mfa_device_name">]
        member _.VirtualMfaDeviceName(state: IamVirtualMfaDeviceState<Missing>, value: string) : IamVirtualMfaDeviceState<Present> =
            state.assignments.Add(fun config -> config.VirtualMfaDeviceName <- value)
            ({ assignments = state.assignments } : IamVirtualMfaDeviceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_virtual_mfa_device#id-1">IamVirtualMfaDevice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamVirtualMfaDeviceState<'VirtualMfaDeviceName>, value: string) : IamVirtualMfaDeviceState<'VirtualMfaDeviceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamVirtualMfaDeviceState<'VirtualMfaDeviceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_virtual_mfa_device#path-1">IamVirtualMfaDevice#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: IamVirtualMfaDeviceState<'VirtualMfaDeviceName>, value: string) : IamVirtualMfaDeviceState<'VirtualMfaDeviceName> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : IamVirtualMfaDeviceState<'VirtualMfaDeviceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_virtual_mfa_device#tags-1">IamVirtualMfaDevice#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamVirtualMfaDeviceState<'VirtualMfaDeviceName>, value: seq<string * string>) : IamVirtualMfaDeviceState<'VirtualMfaDeviceName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamVirtualMfaDeviceState<'VirtualMfaDeviceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_virtual_mfa_device#tags_all-1">IamVirtualMfaDevice#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamVirtualMfaDeviceState<'VirtualMfaDeviceName>, value: seq<string * string>) : IamVirtualMfaDeviceState<'VirtualMfaDeviceName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamVirtualMfaDeviceState<'VirtualMfaDeviceName>

        member _.Run(state: IamVirtualMfaDeviceState<Present>) : aws.IamVirtualMfaDevice.IamVirtualMfaDevice =
            let config = aws.IamVirtualMfaDevice.IamVirtualMfaDeviceConfig()
            for setter in state.assignments do
                setter config
            aws.IamVirtualMfaDevice.IamVirtualMfaDevice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamVirtualMfaDevice: missing required arguments. Must call: virtual_mfa_device_name.", 9999, IsError = true)>]
        member _.Run(_: IamVirtualMfaDeviceState<_>) : aws.IamVirtualMfaDevice.IamVirtualMfaDevice =
            Unchecked.defaultof<aws.IamVirtualMfaDevice.IamVirtualMfaDevice>
