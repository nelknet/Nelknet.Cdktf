namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontFunctionState<'Name, 'Stage> = { assignments: ResizeArray<aws.DataAwsCloudfrontFunction.DataAwsCloudfrontFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_function">aws_cloudfront_function</a>.
    /// </summary>
    type DataAwsCloudfrontFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontFunctionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontFunctionState<Missing, Missing>)

        member _.Zero(()) : DataAwsCloudfrontFunctionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontFunctionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_function#name-1">DataAwsCloudfrontFunction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudfrontFunctionState<Missing, 'Stage>, value: string) : DataAwsCloudfrontFunctionState<Present, 'Stage> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCloudfrontFunctionState<Present, 'Stage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_function#stage-1">DataAwsCloudfrontFunction#stage</a>.
        /// </summary>
        [<CustomOperation "stage">]
        member _.Stage(state: DataAwsCloudfrontFunctionState<'Name, Missing>, value: string) : DataAwsCloudfrontFunctionState<'Name, Present> =
            state.assignments.Add(fun config -> config.Stage <- value)
            ({ assignments = state.assignments } : DataAwsCloudfrontFunctionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_function#id-1">DataAwsCloudfrontFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontFunctionState<'Name, 'Stage>, value: string) : DataAwsCloudfrontFunctionState<'Name, 'Stage> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudfrontFunctionState<'Name, 'Stage>

        member _.Run(state: DataAwsCloudfrontFunctionState<Present, Present>) : aws.DataAwsCloudfrontFunction.DataAwsCloudfrontFunction =
            let config = aws.DataAwsCloudfrontFunction.DataAwsCloudfrontFunctionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontFunction.DataAwsCloudfrontFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudfrontFunction: missing required arguments. Must call: name, stage.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudfrontFunctionState<_, _>) : aws.DataAwsCloudfrontFunction.DataAwsCloudfrontFunction =
            Unchecked.defaultof<aws.DataAwsCloudfrontFunction.DataAwsCloudfrontFunction>
