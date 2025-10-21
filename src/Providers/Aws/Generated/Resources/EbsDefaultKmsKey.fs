namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsDefaultKmsKeyState<'KeyArn> = { assignments: ResizeArray<aws.EbsDefaultKmsKey.EbsDefaultKmsKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_default_kms_key">aws_ebs_default_kms_key</a>.
    /// </summary>
    type EbsDefaultKmsKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsDefaultKmsKeyState<Missing> =
            ({ assignments = ResizeArray() } : EbsDefaultKmsKeyState<Missing>)

        member _.Zero(()) : EbsDefaultKmsKeyState<Missing> =
            ({ assignments = ResizeArray() } : EbsDefaultKmsKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_default_kms_key#key_arn-1">EbsDefaultKmsKey#key_arn</a>.
        /// </summary>
        [<CustomOperation "key_arn">]
        member _.KeyArn(state: EbsDefaultKmsKeyState<Missing>, value: string) : EbsDefaultKmsKeyState<Present> =
            state.assignments.Add(fun config -> config.KeyArn <- value)
            ({ assignments = state.assignments } : EbsDefaultKmsKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_default_kms_key#id-1">EbsDefaultKmsKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EbsDefaultKmsKeyState<'KeyArn>, value: string) : EbsDefaultKmsKeyState<'KeyArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EbsDefaultKmsKeyState<'KeyArn>

        member _.Run(state: EbsDefaultKmsKeyState<Present>) : aws.EbsDefaultKmsKey.EbsDefaultKmsKey =
            let config = aws.EbsDefaultKmsKey.EbsDefaultKmsKeyConfig()
            for setter in state.assignments do
                setter config
            aws.EbsDefaultKmsKey.EbsDefaultKmsKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ebsDefaultKmsKey: missing required arguments. Must call: key_arn.", 9999, IsError = true)>]
        member _.Run(_: EbsDefaultKmsKeyState<_>) : aws.EbsDefaultKmsKey.EbsDefaultKmsKey =
            Unchecked.defaultof<aws.EbsDefaultKmsKey.EbsDefaultKmsKey>
