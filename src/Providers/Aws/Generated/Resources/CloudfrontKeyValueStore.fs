namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontKeyValueStoreState<'Name> = { assignments: ResizeArray<aws.CloudfrontKeyValueStore.CloudfrontKeyValueStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_value_store">aws_cloudfront_key_value_store</a>.
    /// </summary>
    type CloudfrontKeyValueStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontKeyValueStoreState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontKeyValueStoreState<Missing>)

        member _.Zero(()) : CloudfrontKeyValueStoreState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontKeyValueStoreState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_value_store#name-1">CloudfrontKeyValueStore#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontKeyValueStoreState<Missing>, value: string) : CloudfrontKeyValueStoreState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontKeyValueStoreState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_value_store#comment-1">CloudfrontKeyValueStore#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontKeyValueStoreState<'Name>, value: string) : CloudfrontKeyValueStoreState<'Name> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontKeyValueStoreState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_value_store#timeouts-1">CloudfrontKeyValueStore#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudfrontKeyValueStoreState<'Name>, value: aws.CloudfrontKeyValueStore.CloudfrontKeyValueStoreTimeouts) : CloudfrontKeyValueStoreState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudfrontKeyValueStoreState<'Name>

        member _.Run(state: CloudfrontKeyValueStoreState<Present>) : aws.CloudfrontKeyValueStore.CloudfrontKeyValueStore =
            let config = aws.CloudfrontKeyValueStore.CloudfrontKeyValueStoreConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontKeyValueStore.CloudfrontKeyValueStore(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontKeyValueStore: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontKeyValueStoreState<_>) : aws.CloudfrontKeyValueStore.CloudfrontKeyValueStore =
            Unchecked.defaultof<aws.CloudfrontKeyValueStore.CloudfrontKeyValueStore>
