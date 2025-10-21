namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmParametersByPathState<'Path> = { assignments: ResizeArray<aws.DataAwsSsmParametersByPath.DataAwsSsmParametersByPathConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameters_by_path">aws_ssm_parameters_by_path</a>.
    /// </summary>
    type DataAwsSsmParametersByPathBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmParametersByPathState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmParametersByPathState<Missing>)

        member _.Zero(()) : DataAwsSsmParametersByPathState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmParametersByPathState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameters_by_path#path-1">DataAwsSsmParametersByPath#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: DataAwsSsmParametersByPathState<Missing>, value: string) : DataAwsSsmParametersByPathState<Present> =
            state.assignments.Add(fun config -> config.Path <- value)
            ({ assignments = state.assignments } : DataAwsSsmParametersByPathState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameters_by_path#id-1">DataAwsSsmParametersByPath#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmParametersByPathState<'Path>, value: string) : DataAwsSsmParametersByPathState<'Path> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmParametersByPathState<'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameters_by_path#recursive-1">DataAwsSsmParametersByPath#recursive</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "recursive">]
        member _.Recursive(state: DataAwsSsmParametersByPathState<'Path>, value: bool) : DataAwsSsmParametersByPathState<'Path> =
            state.assignments.Add(fun config -> config.Recursive <- value)
            state : DataAwsSsmParametersByPathState<'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameters_by_path#recursive-1">DataAwsSsmParametersByPath#recursive</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "recursive">]
        member _.Recursive(state: DataAwsSsmParametersByPathState<'Path>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmParametersByPathState<'Path> =
            state.assignments.Add(fun config -> config.Recursive <- value)
            state : DataAwsSsmParametersByPathState<'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameters_by_path#with_decryption-1">DataAwsSsmParametersByPath#with_decryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_decryption">]
        member _.WithDecryption(state: DataAwsSsmParametersByPathState<'Path>, value: bool) : DataAwsSsmParametersByPathState<'Path> =
            state.assignments.Add(fun config -> config.WithDecryption <- value)
            state : DataAwsSsmParametersByPathState<'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_parameters_by_path#with_decryption-1">DataAwsSsmParametersByPath#with_decryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_decryption">]
        member _.WithDecryption(state: DataAwsSsmParametersByPathState<'Path>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmParametersByPathState<'Path> =
            state.assignments.Add(fun config -> config.WithDecryption <- value)
            state : DataAwsSsmParametersByPathState<'Path>

        member _.Run(state: DataAwsSsmParametersByPathState<Present>) : aws.DataAwsSsmParametersByPath.DataAwsSsmParametersByPath =
            let config = aws.DataAwsSsmParametersByPath.DataAwsSsmParametersByPathConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmParametersByPath.DataAwsSsmParametersByPath(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmParametersByPath: missing required arguments. Must call: path.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmParametersByPathState<_>) : aws.DataAwsSsmParametersByPath.DataAwsSsmParametersByPath =
            Unchecked.defaultof<aws.DataAwsSsmParametersByPath.DataAwsSsmParametersByPath>
