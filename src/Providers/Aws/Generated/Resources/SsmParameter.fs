namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmParameterState<'Name, 'Type> = { assignments: ResizeArray<aws.SsmParameter.SsmParameterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter">aws_ssm_parameter</a>.
    /// </summary>
    type SsmParameterBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmParameterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmParameterState<Missing, Missing>)

        member _.Zero(()) : SsmParameterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmParameterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#name-1">SsmParameter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmParameterState<Missing, 'Type>, value: string) : SsmParameterState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmParameterState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#type-1">SsmParameter#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SsmParameterState<'Name, Missing>, value: string) : SsmParameterState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : SsmParameterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#allowed_pattern-1">SsmParameter#allowed_pattern</a>.
        /// </summary>
        [<CustomOperation "allowed_pattern">]
        member _.AllowedPattern(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.AllowedPattern <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#arn-1">SsmParameter#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#data_type-1">SsmParameter#data_type</a>.
        /// </summary>
        [<CustomOperation "data_type">]
        member _.DataType(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.DataType <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#description-1">SsmParameter#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#id-1">SsmParameter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#insecure_value-1">SsmParameter#insecure_value</a>.
        /// </summary>
        [<CustomOperation "insecure_value">]
        member _.InsecureValue(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.InsecureValue <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#key_id-1">SsmParameter#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#overwrite-1">SsmParameter#overwrite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "overwrite">]
        member _.Overwrite(state: SsmParameterState<'Name, 'Type>, value: bool) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Overwrite <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#overwrite-1">SsmParameter#overwrite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "overwrite">]
        member _.Overwrite(state: SsmParameterState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Overwrite <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#tags-1">SsmParameter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmParameterState<'Name, 'Type>, value: seq<string * string>) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#tags_all-1">SsmParameter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmParameterState<'Name, 'Type>, value: seq<string * string>) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#tier-1">SsmParameter#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tier <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#value-1">SsmParameter#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#value_wo-1">SsmParameter#value_wo</a>.
        /// </summary>
        [<CustomOperation "value_wo">]
        member _.ValueWo(state: SsmParameterState<'Name, 'Type>, value: string) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.ValueWo <- value)
            state : SsmParameterState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_parameter#value_wo_version-1">SsmParameter#value_wo_version</a>.
        /// </summary>
        [<CustomOperation "value_wo_version">]
        member _.ValueWoVersion(state: SsmParameterState<'Name, 'Type>, value: double) : SsmParameterState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.ValueWoVersion <- value)
            state : SsmParameterState<'Name, 'Type>

        member _.Run(state: SsmParameterState<Present, Present>) : aws.SsmParameter.SsmParameter =
            let config = aws.SsmParameter.SsmParameterConfig()
            for setter in state.assignments do
                setter config
            aws.SsmParameter.SsmParameter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmParameter: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: SsmParameterState<_, _>) : aws.SsmParameter.SsmParameter =
            Unchecked.defaultof<aws.SsmParameter.SsmParameter>
