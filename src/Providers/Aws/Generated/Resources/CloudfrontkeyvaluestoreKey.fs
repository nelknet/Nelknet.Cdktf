namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontkeyvaluestoreKeyState<'Key, 'KeyValueStoreArn, 'Value> = { assignments: ResizeArray<aws.CloudfrontkeyvaluestoreKey.CloudfrontkeyvaluestoreKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_key">aws_cloudfrontkeyvaluestore_key</a>.
    /// </summary>
    type CloudfrontkeyvaluestoreKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontkeyvaluestoreKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontkeyvaluestoreKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudfrontkeyvaluestoreKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontkeyvaluestoreKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// The key to put. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_key#key-1">CloudfrontkeyvaluestoreKey#key</a>
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: CloudfrontkeyvaluestoreKeyState<Missing, 'KeyValueStoreArn, 'Value>, value: string) : CloudfrontkeyvaluestoreKeyState<Present, 'KeyValueStoreArn, 'Value> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : CloudfrontkeyvaluestoreKeyState<Present, 'KeyValueStoreArn, 'Value>)

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Key Value Store. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_key#key_value_store_arn-1">CloudfrontkeyvaluestoreKey#key_value_store_arn</a>
        /// </summary>
        [<CustomOperation "key_value_store_arn">]
        member _.KeyValueStoreArn(state: CloudfrontkeyvaluestoreKeyState<'Key, Missing, 'Value>, value: string) : CloudfrontkeyvaluestoreKeyState<'Key, Present, 'Value> =
            state.assignments.Add(fun config -> config.KeyValueStoreArn <- value)
            ({ assignments = state.assignments } : CloudfrontkeyvaluestoreKeyState<'Key, Present, 'Value>)

        /// <summary>
        /// The value to put. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfrontkeyvaluestore_key#value-1">CloudfrontkeyvaluestoreKey#value</a>
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: CloudfrontkeyvaluestoreKeyState<'Key, 'KeyValueStoreArn, Missing>, value: string) : CloudfrontkeyvaluestoreKeyState<'Key, 'KeyValueStoreArn, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : CloudfrontkeyvaluestoreKeyState<'Key, 'KeyValueStoreArn, Present>)

        member _.Run(state: CloudfrontkeyvaluestoreKeyState<Present, Present, Present>) : aws.CloudfrontkeyvaluestoreKey.CloudfrontkeyvaluestoreKey =
            let config = aws.CloudfrontkeyvaluestoreKey.CloudfrontkeyvaluestoreKeyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontkeyvaluestoreKey.CloudfrontkeyvaluestoreKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontkeyvaluestoreKey: missing required arguments. Must call: key, key_value_store_arn, value.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontkeyvaluestoreKeyState<_, _, _>) : aws.CloudfrontkeyvaluestoreKey.CloudfrontkeyvaluestoreKey =
            Unchecked.defaultof<aws.CloudfrontkeyvaluestoreKey.CloudfrontkeyvaluestoreKey>
