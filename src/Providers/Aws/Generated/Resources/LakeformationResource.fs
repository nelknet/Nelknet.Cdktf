namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationResourceState<'Arn> = { assignments: ResizeArray<aws.LakeformationResource.LakeformationResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource">aws_lakeformation_resource</a>.
    /// </summary>
    type LakeformationResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationResourceState<Missing> =
            ({ assignments = ResizeArray() } : LakeformationResourceState<Missing>)

        member _.Zero(()) : LakeformationResourceState<Missing> =
            ({ assignments = ResizeArray() } : LakeformationResourceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#arn-1">LakeformationResource#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: LakeformationResourceState<Missing>, value: string) : LakeformationResourceState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : LakeformationResourceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#hybrid_access_enabled-1">LakeformationResource#hybrid_access_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hybrid_access_enabled">]
        member _.HybridAccessEnabled(state: LakeformationResourceState<'Arn>, value: bool) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.HybridAccessEnabled <- value)
            state : LakeformationResourceState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#hybrid_access_enabled-1">LakeformationResource#hybrid_access_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hybrid_access_enabled">]
        member _.HybridAccessEnabled(state: LakeformationResourceState<'Arn>, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.HybridAccessEnabled <- value)
            state : LakeformationResourceState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#id-1">LakeformationResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LakeformationResourceState<'Arn>, value: string) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LakeformationResourceState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#role_arn-1">LakeformationResource#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: LakeformationResourceState<'Arn>, value: string) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : LakeformationResourceState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#use_service_linked_role-1">LakeformationResource#use_service_linked_role</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_service_linked_role">]
        member _.UseServiceLinkedRole(state: LakeformationResourceState<'Arn>, value: bool) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.UseServiceLinkedRole <- value)
            state : LakeformationResourceState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#use_service_linked_role-1">LakeformationResource#use_service_linked_role</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_service_linked_role">]
        member _.UseServiceLinkedRole(state: LakeformationResourceState<'Arn>, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.UseServiceLinkedRole <- value)
            state : LakeformationResourceState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#with_federation-1">LakeformationResource#with_federation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_federation">]
        member _.WithFederation(state: LakeformationResourceState<'Arn>, value: bool) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.WithFederation <- value)
            state : LakeformationResourceState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource#with_federation-1">LakeformationResource#with_federation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_federation">]
        member _.WithFederation(state: LakeformationResourceState<'Arn>, value: HashiCorp.Cdktf.IResolvable) : LakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.WithFederation <- value)
            state : LakeformationResourceState<'Arn>

        member _.Run(state: LakeformationResourceState<Present>) : aws.LakeformationResource.LakeformationResource =
            let config = aws.LakeformationResource.LakeformationResourceConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationResource.LakeformationResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lakeformationResource: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: LakeformationResourceState<_>) : aws.LakeformationResource.LakeformationResource =
            Unchecked.defaultof<aws.LakeformationResource.LakeformationResource>
