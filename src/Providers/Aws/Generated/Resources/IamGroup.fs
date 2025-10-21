namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamGroupState<'Name> = { assignments: ResizeArray<aws.IamGroup.IamGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group">aws_iam_group</a>.
    /// </summary>
    type IamGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamGroupState<Missing> =
            ({ assignments = ResizeArray() } : IamGroupState<Missing>)

        member _.Zero(()) : IamGroupState<Missing> =
            ({ assignments = ResizeArray() } : IamGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group#name-1">IamGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamGroupState<Missing>, value: string) : IamGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IamGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group#id-1">IamGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamGroupState<'Name>, value: string) : IamGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group#path-1">IamGroup#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: IamGroupState<'Name>, value: string) : IamGroupState<'Name> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : IamGroupState<'Name>

        member _.Run(state: IamGroupState<Present>) : aws.IamGroup.IamGroup =
            let config = aws.IamGroup.IamGroupConfig()
            for setter in state.assignments do
                setter config
            aws.IamGroup.IamGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: IamGroupState<_>) : aws.IamGroup.IamGroup =
            Unchecked.defaultof<aws.IamGroup.IamGroup>
