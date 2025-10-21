namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedaccessGroupState<'VerifiedaccessInstanceId> = { assignments: ResizeArray<aws.VerifiedaccessGroup.VerifiedaccessGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group">aws_verifiedaccess_group</a>.
    /// </summary>
    type VerifiedaccessGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedaccessGroupState<Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessGroupState<Missing>)

        member _.Zero(()) : VerifiedaccessGroupState<Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group#verifiedaccess_instance_id-1">VerifiedaccessGroup#verifiedaccess_instance_id</a>.
        /// </summary>
        [<CustomOperation "verifiedaccess_instance_id">]
        member _.VerifiedaccessInstanceId(state: VerifiedaccessGroupState<Missing>, value: string) : VerifiedaccessGroupState<Present> =
            state.assignments.Add(fun config -> config.VerifiedaccessInstanceId <- value)
            ({ assignments = state.assignments } : VerifiedaccessGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group#description-1">VerifiedaccessGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VerifiedaccessGroupState<'VerifiedaccessInstanceId>, value: string) : VerifiedaccessGroupState<'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VerifiedaccessGroupState<'VerifiedaccessInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group#id-1">VerifiedaccessGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VerifiedaccessGroupState<'VerifiedaccessInstanceId>, value: string) : VerifiedaccessGroupState<'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VerifiedaccessGroupState<'VerifiedaccessInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group#policy_document-1">VerifiedaccessGroup#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: VerifiedaccessGroupState<'VerifiedaccessInstanceId>, value: string) : VerifiedaccessGroupState<'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            state : VerifiedaccessGroupState<'VerifiedaccessInstanceId>

        /// <summary>
        /// sse_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group#sse_configuration-1">VerifiedaccessGroup#sse_configuration</a>
        /// </summary>
        [<CustomOperation "sse_configuration">]
        member _.SseConfiguration(state: VerifiedaccessGroupState<'VerifiedaccessInstanceId>, value: aws.VerifiedaccessGroup.VerifiedaccessGroupSseConfiguration) : VerifiedaccessGroupState<'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.SseConfiguration <- value)
            state : VerifiedaccessGroupState<'VerifiedaccessInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group#tags-1">VerifiedaccessGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VerifiedaccessGroupState<'VerifiedaccessInstanceId>, value: seq<string * string>) : VerifiedaccessGroupState<'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VerifiedaccessGroupState<'VerifiedaccessInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_group#tags_all-1">VerifiedaccessGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VerifiedaccessGroupState<'VerifiedaccessInstanceId>, value: seq<string * string>) : VerifiedaccessGroupState<'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VerifiedaccessGroupState<'VerifiedaccessInstanceId>

        member _.Run(state: VerifiedaccessGroupState<Present>) : aws.VerifiedaccessGroup.VerifiedaccessGroup =
            let config = aws.VerifiedaccessGroup.VerifiedaccessGroupConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedaccessGroup.VerifiedaccessGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedaccessGroup: missing required arguments. Must call: verifiedaccess_instance_id.", 9999, IsError = true)>]
        member _.Run(_: VerifiedaccessGroupState<_>) : aws.VerifiedaccessGroup.VerifiedaccessGroup =
            Unchecked.defaultof<aws.VerifiedaccessGroup.VerifiedaccessGroup>
