namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontkeyvaluestoreKeysExclusiveState<'KeyValueStoreArn> = { assignments: ResizeArray<aws.CloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive">aws_cloudfrontkeyvaluestore_keys_exclusive</a>.
    /// </summary>
    type CloudfrontkeyvaluestoreKeysExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontkeyvaluestoreKeysExclusiveState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontkeyvaluestoreKeysExclusiveState<Missing>)

        member _.Zero(()) : CloudfrontkeyvaluestoreKeysExclusiveState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontkeyvaluestoreKeysExclusiveState<Missing>)

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Key Value Store. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#key_value_store_arn-1">CloudfrontkeyvaluestoreKeysExclusive#key_value_store_arn</a>
        /// </summary>
        [<CustomOperation "key_value_store_arn">]
        member _.KeyValueStoreArn(state: CloudfrontkeyvaluestoreKeysExclusiveState<Missing>, value: string) : CloudfrontkeyvaluestoreKeysExclusiveState<Present> =
            state.assignments.Add(fun config -> config.KeyValueStoreArn <- value)
            ({ assignments = state.assignments } : CloudfrontkeyvaluestoreKeysExclusiveState<Present>)

        /// <summary>
        /// Maximum resource key values pairs that you wills update in a single API request. AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#max_batch_size-1">CloudfrontkeyvaluestoreKeysExclusive#max_batch_size</a>
        /// </summary>
        [<CustomOperation "max_batch_size">]
        member _.MaxBatchSize(state: CloudfrontkeyvaluestoreKeysExclusiveState<'KeyValueStoreArn>, value: double) : CloudfrontkeyvaluestoreKeysExclusiveState<'KeyValueStoreArn> =
            state.assignments.Add(fun config -> config.MaxBatchSize <- value)
            state : CloudfrontkeyvaluestoreKeysExclusiveState<'KeyValueStoreArn>

        /// <summary>
        /// resource_key_value_pair block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#resource_key_value_pair-1">CloudfrontkeyvaluestoreKeysExclusive#resource_key_value_pair</a> Accepts: aws.IResolvable | aws.CloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePair[]
        /// </summary>
        [<CustomOperation "resource_key_value_pair">]
        member _.ResourceKeyValuePair(state: CloudfrontkeyvaluestoreKeysExclusiveState<'KeyValueStoreArn>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontkeyvaluestoreKeysExclusiveState<'KeyValueStoreArn> =
            state.assignments.Add(fun config -> config.ResourceKeyValuePair <- value)
            state : CloudfrontkeyvaluestoreKeysExclusiveState<'KeyValueStoreArn>

        member _.Run(state: CloudfrontkeyvaluestoreKeysExclusiveState<Present>) : aws.CloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusive =
            let config = aws.CloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontkeyvaluestoreKeysExclusive: missing required arguments. Must call: key_value_store_arn.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontkeyvaluestoreKeysExclusiveState<_>) : aws.CloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusive =
            Unchecked.defaultof<aws.CloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusive>
