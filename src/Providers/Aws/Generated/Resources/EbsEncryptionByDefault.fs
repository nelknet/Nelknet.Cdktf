namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsEncryptionByDefaultState = { assignments: ResizeArray<aws.EbsEncryptionByDefault.EbsEncryptionByDefaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_encryption_by_default">aws_ebs_encryption_by_default</a>.
    /// </summary>
    type EbsEncryptionByDefaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsEncryptionByDefaultState =
            { assignments = ResizeArray() }

        member _.Zero(()) : EbsEncryptionByDefaultState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_encryption_by_default#enabled-1">EbsEncryptionByDefault#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: EbsEncryptionByDefaultState, value: bool) : EbsEncryptionByDefaultState =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : EbsEncryptionByDefaultState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_encryption_by_default#enabled-1">EbsEncryptionByDefault#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: EbsEncryptionByDefaultState, value: HashiCorp.Cdktf.IResolvable) : EbsEncryptionByDefaultState =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : EbsEncryptionByDefaultState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_encryption_by_default#id-1">EbsEncryptionByDefault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EbsEncryptionByDefaultState, value: string) : EbsEncryptionByDefaultState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EbsEncryptionByDefaultState

        member _.Run(state: EbsEncryptionByDefaultState) : aws.EbsEncryptionByDefault.EbsEncryptionByDefault =
            let config = aws.EbsEncryptionByDefault.EbsEncryptionByDefaultConfig()
            for setter in state.assignments do
                setter config
            aws.EbsEncryptionByDefault.EbsEncryptionByDefault(StackContext.get (), logicalId, config)
