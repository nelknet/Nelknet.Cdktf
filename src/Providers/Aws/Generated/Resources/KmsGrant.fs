namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> = { assignments: ResizeArray<aws.KmsGrant.KmsGrantConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant">aws_kms_grant</a>.
    /// </summary>
    type KmsGrantBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsGrantState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KmsGrantState<Missing, Missing, Missing>)

        member _.Zero(()) : KmsGrantState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KmsGrantState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#grantee_principal-1">KmsGrant#grantee_principal</a>.
        /// </summary>
        [<CustomOperation "grantee_principal">]
        member _.GranteePrincipal(state: KmsGrantState<Missing, 'KeyId, 'Operations>, value: string) : KmsGrantState<Present, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.GranteePrincipal <- value)
            ({ assignments = state.assignments } : KmsGrantState<Present, 'KeyId, 'Operations>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#key_id-1">KmsGrant#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: KmsGrantState<'GranteePrincipal, Missing, 'Operations>, value: string) : KmsGrantState<'GranteePrincipal, Present, 'Operations> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            ({ assignments = state.assignments } : KmsGrantState<'GranteePrincipal, Present, 'Operations>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#operations-1">KmsGrant#operations</a>.
        /// </summary>
        [<CustomOperation "operations">]
        member _.Operations(state: KmsGrantState<'GranteePrincipal, 'KeyId, Missing>, value: seq<string>) : KmsGrantState<'GranteePrincipal, 'KeyId, Present> =
            state.assignments.Add(fun config -> config.Operations <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : KmsGrantState<'GranteePrincipal, 'KeyId, Present>)

        /// <summary>
        /// constraints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#constraints-1">KmsGrant#constraints</a> Accepts: aws.IResolvable | aws.KmsGrant.KmsGrantConstraints[]
        /// </summary>
        [<CustomOperation "constraints">]
        member _.Constraints(state: KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>, value: HashiCorp.Cdktf.IResolvable) : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.Constraints <- value)
            state : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#grant_creation_tokens-1">KmsGrant#grant_creation_tokens</a>.
        /// </summary>
        [<CustomOperation "grant_creation_tokens">]
        member _.GrantCreationTokens(state: KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>, value: seq<string>) : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.GrantCreationTokens <- (value |> Seq.toArray))
            state : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#id-1">KmsGrant#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>, value: string) : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#name-1">KmsGrant#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>, value: string) : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#retire_on_delete-1">KmsGrant#retire_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retire_on_delete">]
        member _.RetireOnDelete(state: KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>, value: bool) : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.RetireOnDelete <- value)
            state : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#retire_on_delete-1">KmsGrant#retire_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retire_on_delete">]
        member _.RetireOnDelete(state: KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>, value: HashiCorp.Cdktf.IResolvable) : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.RetireOnDelete <- value)
            state : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#retiring_principal-1">KmsGrant#retiring_principal</a>.
        /// </summary>
        [<CustomOperation "retiring_principal">]
        member _.RetiringPrincipal(state: KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>, value: string) : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations> =
            state.assignments.Add(fun config -> config.RetiringPrincipal <- value)
            state : KmsGrantState<'GranteePrincipal, 'KeyId, 'Operations>

        member _.Run(state: KmsGrantState<Present, Present, Present>) : aws.KmsGrant.KmsGrant =
            let config = aws.KmsGrant.KmsGrantConfig()
            for setter in state.assignments do
                setter config
            aws.KmsGrant.KmsGrant(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kmsGrant: missing required arguments. Must call: grantee_principal, key_id, operations.", 9999, IsError = true)>]
        member _.Run(_: KmsGrantState<_, _, _>) : aws.KmsGrant.KmsGrant =
            Unchecked.defaultof<aws.KmsGrant.KmsGrant>
