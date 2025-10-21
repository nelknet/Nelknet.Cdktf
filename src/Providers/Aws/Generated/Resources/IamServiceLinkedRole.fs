namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamServiceLinkedRoleState<'AwsServiceName> = { assignments: ResizeArray<aws.IamServiceLinkedRole.IamServiceLinkedRoleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_linked_role">aws_iam_service_linked_role</a>.
    /// </summary>
    type IamServiceLinkedRoleBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamServiceLinkedRoleState<Missing> =
            ({ assignments = ResizeArray() } : IamServiceLinkedRoleState<Missing>)

        member _.Zero(()) : IamServiceLinkedRoleState<Missing> =
            ({ assignments = ResizeArray() } : IamServiceLinkedRoleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_linked_role#aws_service_name-1">IamServiceLinkedRole#aws_service_name</a>.
        /// </summary>
        [<CustomOperation "aws_service_name">]
        member _.AwsServiceName(state: IamServiceLinkedRoleState<Missing>, value: string) : IamServiceLinkedRoleState<Present> =
            state.assignments.Add(fun config -> config.AwsServiceName <- value)
            ({ assignments = state.assignments } : IamServiceLinkedRoleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_linked_role#custom_suffix-1">IamServiceLinkedRole#custom_suffix</a>.
        /// </summary>
        [<CustomOperation "custom_suffix">]
        member _.CustomSuffix(state: IamServiceLinkedRoleState<'AwsServiceName>, value: string) : IamServiceLinkedRoleState<'AwsServiceName> =
            state.assignments.Add(fun config -> config.CustomSuffix <- value)
            state : IamServiceLinkedRoleState<'AwsServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_linked_role#description-1">IamServiceLinkedRole#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: IamServiceLinkedRoleState<'AwsServiceName>, value: string) : IamServiceLinkedRoleState<'AwsServiceName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : IamServiceLinkedRoleState<'AwsServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_linked_role#id-1">IamServiceLinkedRole#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamServiceLinkedRoleState<'AwsServiceName>, value: string) : IamServiceLinkedRoleState<'AwsServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamServiceLinkedRoleState<'AwsServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_linked_role#tags-1">IamServiceLinkedRole#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamServiceLinkedRoleState<'AwsServiceName>, value: seq<string * string>) : IamServiceLinkedRoleState<'AwsServiceName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamServiceLinkedRoleState<'AwsServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_linked_role#tags_all-1">IamServiceLinkedRole#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamServiceLinkedRoleState<'AwsServiceName>, value: seq<string * string>) : IamServiceLinkedRoleState<'AwsServiceName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamServiceLinkedRoleState<'AwsServiceName>

        member _.Run(state: IamServiceLinkedRoleState<Present>) : aws.IamServiceLinkedRole.IamServiceLinkedRole =
            let config = aws.IamServiceLinkedRole.IamServiceLinkedRoleConfig()
            for setter in state.assignments do
                setter config
            aws.IamServiceLinkedRole.IamServiceLinkedRole(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamServiceLinkedRole: missing required arguments. Must call: aws_service_name.", 9999, IsError = true)>]
        member _.Run(_: IamServiceLinkedRoleState<_>) : aws.IamServiceLinkedRole.IamServiceLinkedRole =
            Unchecked.defaultof<aws.IamServiceLinkedRole.IamServiceLinkedRole>
