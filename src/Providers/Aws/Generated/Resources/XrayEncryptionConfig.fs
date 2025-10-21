namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type XrayEncryptionConfigState<'Type> = { assignments: ResizeArray<aws.XrayEncryptionConfig.XrayEncryptionConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_encryption_config">aws_xray_encryption_config</a>.
    /// </summary>
    type XrayEncryptionConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : XrayEncryptionConfigState<Missing> =
            ({ assignments = ResizeArray() } : XrayEncryptionConfigState<Missing>)

        member _.Zero(()) : XrayEncryptionConfigState<Missing> =
            ({ assignments = ResizeArray() } : XrayEncryptionConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_encryption_config#type-1">XrayEncryptionConfig#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: XrayEncryptionConfigState<Missing>, value: string) : XrayEncryptionConfigState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : XrayEncryptionConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_encryption_config#id-1">XrayEncryptionConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: XrayEncryptionConfigState<'Type>, value: string) : XrayEncryptionConfigState<'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : XrayEncryptionConfigState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_encryption_config#key_id-1">XrayEncryptionConfig#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: XrayEncryptionConfigState<'Type>, value: string) : XrayEncryptionConfigState<'Type> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            state : XrayEncryptionConfigState<'Type>

        member _.Run(state: XrayEncryptionConfigState<Present>) : aws.XrayEncryptionConfig.XrayEncryptionConfig =
            let config = aws.XrayEncryptionConfig.XrayEncryptionConfigConfig()
            for setter in state.assignments do
                setter config
            aws.XrayEncryptionConfig.XrayEncryptionConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.xrayEncryptionConfig: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: XrayEncryptionConfigState<_>) : aws.XrayEncryptionConfig.XrayEncryptionConfig =
            Unchecked.defaultof<aws.XrayEncryptionConfig.XrayEncryptionConfig>
