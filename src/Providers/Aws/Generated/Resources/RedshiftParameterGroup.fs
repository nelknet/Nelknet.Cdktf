namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftParameterGroupState<'Family, 'Name> = { assignments: ResizeArray<aws.RedshiftParameterGroup.RedshiftParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group">aws_redshift_parameter_group</a>.
    /// </summary>
    type RedshiftParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftParameterGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftParameterGroupState<Missing, Missing>)

        member _.Zero(()) : RedshiftParameterGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftParameterGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group#family-1">RedshiftParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: RedshiftParameterGroupState<Missing, 'Name>, value: string) : RedshiftParameterGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : RedshiftParameterGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group#name-1">RedshiftParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedshiftParameterGroupState<'Family, Missing>, value: string) : RedshiftParameterGroupState<'Family, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedshiftParameterGroupState<'Family, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group#description-1">RedshiftParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RedshiftParameterGroupState<'Family, 'Name>, value: string) : RedshiftParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RedshiftParameterGroupState<'Family, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group#id-1">RedshiftParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftParameterGroupState<'Family, 'Name>, value: string) : RedshiftParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftParameterGroupState<'Family, 'Name>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group#parameter-1">RedshiftParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.RedshiftParameterGroup.RedshiftParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: RedshiftParameterGroupState<'Family, 'Name>, value: HashiCorp.Cdktf.IResolvable) : RedshiftParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : RedshiftParameterGroupState<'Family, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group#tags-1">RedshiftParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftParameterGroupState<'Family, 'Name>, value: seq<string * string>) : RedshiftParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftParameterGroupState<'Family, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_parameter_group#tags_all-1">RedshiftParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftParameterGroupState<'Family, 'Name>, value: seq<string * string>) : RedshiftParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftParameterGroupState<'Family, 'Name>

        member _.Run(state: RedshiftParameterGroupState<Present, Present>) : aws.RedshiftParameterGroup.RedshiftParameterGroup =
            let config = aws.RedshiftParameterGroup.RedshiftParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftParameterGroup.RedshiftParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftParameterGroup: missing required arguments. Must call: family, name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftParameterGroupState<_, _>) : aws.RedshiftParameterGroup.RedshiftParameterGroup =
            Unchecked.defaultof<aws.RedshiftParameterGroup.RedshiftParameterGroup>
