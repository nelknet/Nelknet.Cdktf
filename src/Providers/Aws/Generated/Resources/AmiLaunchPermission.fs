namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmiLaunchPermissionState<'ImageId> = { assignments: ResizeArray<aws.AmiLaunchPermission.AmiLaunchPermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_launch_permission">aws_ami_launch_permission</a>.
    /// </summary>
    type AmiLaunchPermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmiLaunchPermissionState<Missing> =
            ({ assignments = ResizeArray() } : AmiLaunchPermissionState<Missing>)

        member _.Zero(()) : AmiLaunchPermissionState<Missing> =
            ({ assignments = ResizeArray() } : AmiLaunchPermissionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_launch_permission#image_id-1">AmiLaunchPermission#image_id</a>.
        /// </summary>
        [<CustomOperation "image_id">]
        member _.ImageId(state: AmiLaunchPermissionState<Missing>, value: string) : AmiLaunchPermissionState<Present> =
            state.assignments.Add(fun config -> config.ImageId <- value)
            ({ assignments = state.assignments } : AmiLaunchPermissionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_launch_permission#account_id-1">AmiLaunchPermission#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: AmiLaunchPermissionState<'ImageId>, value: string) : AmiLaunchPermissionState<'ImageId> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : AmiLaunchPermissionState<'ImageId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_launch_permission#group-1">AmiLaunchPermission#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: AmiLaunchPermissionState<'ImageId>, value: string) : AmiLaunchPermissionState<'ImageId> =
            state.assignments.Add(fun config -> config.Group <- value)
            state : AmiLaunchPermissionState<'ImageId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_launch_permission#id-1">AmiLaunchPermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmiLaunchPermissionState<'ImageId>, value: string) : AmiLaunchPermissionState<'ImageId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmiLaunchPermissionState<'ImageId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_launch_permission#organizational_unit_arn-1">AmiLaunchPermission#organizational_unit_arn</a>.
        /// </summary>
        [<CustomOperation "organizational_unit_arn">]
        member _.OrganizationalUnitArn(state: AmiLaunchPermissionState<'ImageId>, value: string) : AmiLaunchPermissionState<'ImageId> =
            state.assignments.Add(fun config -> config.OrganizationalUnitArn <- value)
            state : AmiLaunchPermissionState<'ImageId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_launch_permission#organization_arn-1">AmiLaunchPermission#organization_arn</a>.
        /// </summary>
        [<CustomOperation "organization_arn">]
        member _.OrganizationArn(state: AmiLaunchPermissionState<'ImageId>, value: string) : AmiLaunchPermissionState<'ImageId> =
            state.assignments.Add(fun config -> config.OrganizationArn <- value)
            state : AmiLaunchPermissionState<'ImageId>

        member _.Run(state: AmiLaunchPermissionState<Present>) : aws.AmiLaunchPermission.AmiLaunchPermission =
            let config = aws.AmiLaunchPermission.AmiLaunchPermissionConfig()
            for setter in state.assignments do
                setter config
            aws.AmiLaunchPermission.AmiLaunchPermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amiLaunchPermission: missing required arguments. Must call: image_id.", 9999, IsError = true)>]
        member _.Run(_: AmiLaunchPermissionState<_>) : aws.AmiLaunchPermission.AmiLaunchPermission =
            Unchecked.defaultof<aws.AmiLaunchPermission.AmiLaunchPermission>
