namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DaxParameterGroupState<'Name> = { assignments: ResizeArray<aws.DaxParameterGroup.DaxParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_parameter_group">aws_dax_parameter_group</a>.
    /// </summary>
    type DaxParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DaxParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DaxParameterGroupState<Missing>)

        member _.Zero(()) : DaxParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DaxParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_parameter_group#name-1">DaxParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DaxParameterGroupState<Missing>, value: string) : DaxParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DaxParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_parameter_group#description-1">DaxParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DaxParameterGroupState<'Name>, value: string) : DaxParameterGroupState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DaxParameterGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_parameter_group#id-1">DaxParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DaxParameterGroupState<'Name>, value: string) : DaxParameterGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DaxParameterGroupState<'Name>

        /// <summary>
        /// parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_parameter_group#parameters-1">DaxParameterGroup#parameters</a> Accepts: aws.IResolvable | aws.DaxParameterGroup.DaxParameterGroupParameters[]
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DaxParameterGroupState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DaxParameterGroupState<'Name> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : DaxParameterGroupState<'Name>

        member _.Run(state: DaxParameterGroupState<Present>) : aws.DaxParameterGroup.DaxParameterGroup =
            let config = aws.DaxParameterGroup.DaxParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DaxParameterGroup.DaxParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.daxParameterGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DaxParameterGroupState<_>) : aws.DaxParameterGroup.DaxParameterGroup =
            Unchecked.defaultof<aws.DaxParameterGroup.DaxParameterGroup>
