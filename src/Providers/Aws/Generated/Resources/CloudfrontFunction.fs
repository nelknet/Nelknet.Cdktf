namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontFunctionState<'Code, 'Name, 'Runtime> = { assignments: ResizeArray<aws.CloudfrontFunction.CloudfrontFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function">aws_cloudfront_function</a>.
    /// </summary>
    type CloudfrontFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontFunctionState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudfrontFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontFunctionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#code-1">CloudfrontFunction#code</a>.
        /// </summary>
        [<CustomOperation "code">]
        member _.Code(state: CloudfrontFunctionState<Missing, 'Name, 'Runtime>, value: string) : CloudfrontFunctionState<Present, 'Name, 'Runtime> =
            state.assignments.Add(fun config -> config.Code <- value)
            ({ assignments = state.assignments } : CloudfrontFunctionState<Present, 'Name, 'Runtime>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#name-1">CloudfrontFunction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontFunctionState<'Code, Missing, 'Runtime>, value: string) : CloudfrontFunctionState<'Code, Present, 'Runtime> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontFunctionState<'Code, Present, 'Runtime>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#runtime-1">CloudfrontFunction#runtime</a>.
        /// </summary>
        [<CustomOperation "runtime">]
        member _.Runtime(state: CloudfrontFunctionState<'Code, 'Name, Missing>, value: string) : CloudfrontFunctionState<'Code, 'Name, Present> =
            state.assignments.Add(fun config -> config.Runtime <- value)
            ({ assignments = state.assignments } : CloudfrontFunctionState<'Code, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#comment-1">CloudfrontFunction#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontFunctionState<'Code, 'Name, 'Runtime>, value: string) : CloudfrontFunctionState<'Code, 'Name, 'Runtime> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontFunctionState<'Code, 'Name, 'Runtime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#id-1">CloudfrontFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontFunctionState<'Code, 'Name, 'Runtime>, value: string) : CloudfrontFunctionState<'Code, 'Name, 'Runtime> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontFunctionState<'Code, 'Name, 'Runtime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#key_value_store_associations-1">CloudfrontFunction#key_value_store_associations</a>.
        /// </summary>
        [<CustomOperation "key_value_store_associations">]
        member _.KeyValueStoreAssociations(state: CloudfrontFunctionState<'Code, 'Name, 'Runtime>, value: seq<string>) : CloudfrontFunctionState<'Code, 'Name, 'Runtime> =
            state.assignments.Add(fun config -> config.KeyValueStoreAssociations <- (value |> Seq.toArray))
            state : CloudfrontFunctionState<'Code, 'Name, 'Runtime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#publish-1">CloudfrontFunction#publish</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publish">]
        member _.Publish(state: CloudfrontFunctionState<'Code, 'Name, 'Runtime>, value: bool) : CloudfrontFunctionState<'Code, 'Name, 'Runtime> =
            state.assignments.Add(fun config -> config.Publish <- value)
            state : CloudfrontFunctionState<'Code, 'Name, 'Runtime>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_function#publish-1">CloudfrontFunction#publish</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publish">]
        member _.Publish(state: CloudfrontFunctionState<'Code, 'Name, 'Runtime>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontFunctionState<'Code, 'Name, 'Runtime> =
            state.assignments.Add(fun config -> config.Publish <- value)
            state : CloudfrontFunctionState<'Code, 'Name, 'Runtime>

        member _.Run(state: CloudfrontFunctionState<Present, Present, Present>) : aws.CloudfrontFunction.CloudfrontFunction =
            let config = aws.CloudfrontFunction.CloudfrontFunctionConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontFunction.CloudfrontFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontFunction: missing required arguments. Must call: code, name, runtime.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontFunctionState<_, _, _>) : aws.CloudfrontFunction.CloudfrontFunction =
            Unchecked.defaultof<aws.CloudfrontFunction.CloudfrontFunction>
