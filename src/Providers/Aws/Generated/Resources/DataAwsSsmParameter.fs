namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmParameterState<'Name> = { assignments: ResizeArray<aws.DataAwsSsmParameter.DataAwsSsmParameterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameter">aws_ssm_parameter</a>.
    /// </summary>
    type DataAwsSsmParameterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmParameterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmParameterState<Missing>)

        member _.Zero(()) : DataAwsSsmParameterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmParameterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameter#name-1">DataAwsSsmParameter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSsmParameterState<Missing>, value: string) : DataAwsSsmParameterState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsSsmParameterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameter#id-1">DataAwsSsmParameter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmParameterState<'Name>, value: string) : DataAwsSsmParameterState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmParameterState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameter#with_decryption-1">DataAwsSsmParameter#with_decryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_decryption">]
        member _.WithDecryption(state: DataAwsSsmParameterState<'Name>, value: bool) : DataAwsSsmParameterState<'Name> =
            state.assignments.Add(fun config -> config.WithDecryption <- value)
            state : DataAwsSsmParameterState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameter#with_decryption-1">DataAwsSsmParameter#with_decryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_decryption">]
        member _.WithDecryption(state: DataAwsSsmParameterState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmParameterState<'Name> =
            state.assignments.Add(fun config -> config.WithDecryption <- value)
            state : DataAwsSsmParameterState<'Name>

        member _.Run(state: DataAwsSsmParameterState<Present>) : aws.DataAwsSsmParameter.DataAwsSsmParameter =
            let config = aws.DataAwsSsmParameter.DataAwsSsmParameterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmParameter.DataAwsSsmParameter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmParameter: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmParameterState<_>) : aws.DataAwsSsmParameter.DataAwsSsmParameter =
            Unchecked.defaultof<aws.DataAwsSsmParameter.DataAwsSsmParameter>
