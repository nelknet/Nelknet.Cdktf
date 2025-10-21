using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesProfile
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile aws_customerprofiles_profile}.</summary>
    [JsiiClass(nativeType: typeof(aws.CustomerprofilesProfile.CustomerprofilesProfile), fullyQualifiedName: "aws.customerprofilesProfile.CustomerprofilesProfile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileConfig\"}}]")]
    public class CustomerprofilesProfile : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile aws_customerprofiles_profile} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CustomerprofilesProfile(Constructs.Construct scope, string id, aws.CustomerprofilesProfile.ICustomerprofilesProfileConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CustomerprofilesProfile.ICustomerprofilesProfileConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerprofilesProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerprofilesProfile(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CustomerprofilesProfile resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CustomerprofilesProfile to import.</param>
        /// <param name="importFromId">The id of the existing CustomerprofilesProfile that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CustomerprofilesProfile to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CustomerprofilesProfile to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_profile#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CustomerprofilesProfile that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CustomerprofilesProfile to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CustomerprofilesProfile.CustomerprofilesProfile), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileAddress\"}}]")]
        public virtual void PutAddress(aws.CustomerprofilesProfile.ICustomerprofilesProfileAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesProfile.ICustomerprofilesProfileAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBillingAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileBillingAddress\"}}]")]
        public virtual void PutBillingAddress(aws.CustomerprofilesProfile.ICustomerprofilesProfileBillingAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesProfile.ICustomerprofilesProfileBillingAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMailingAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileMailingAddress\"}}]")]
        public virtual void PutMailingAddress(aws.CustomerprofilesProfile.ICustomerprofilesProfileMailingAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesProfile.ICustomerprofilesProfileMailingAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShippingAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileShippingAddress\"}}]")]
        public virtual void PutShippingAddress(aws.CustomerprofilesProfile.ICustomerprofilesProfileShippingAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesProfile.ICustomerprofilesProfileShippingAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountNumber")]
        public virtual void ResetAccountNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdditionalInformation")]
        public virtual void ResetAdditionalInformation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillingAddress")]
        public virtual void ResetBillingAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBirthDate")]
        public virtual void ResetBirthDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBusinessEmailAddress")]
        public virtual void ResetBusinessEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBusinessName")]
        public virtual void ResetBusinessName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBusinessPhoneNumber")]
        public virtual void ResetBusinessPhoneNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailAddress")]
        public virtual void ResetEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstName")]
        public virtual void ResetFirstName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenderString")]
        public virtual void ResetGenderString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHomePhoneNumber")]
        public virtual void ResetHomePhoneNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastName")]
        public virtual void ResetLastName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMailingAddress")]
        public virtual void ResetMailingAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMiddleName")]
        public virtual void ResetMiddleName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMobilePhoneNumber")]
        public virtual void ResetMobilePhoneNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartyTypeString")]
        public virtual void ResetPartyTypeString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersonalEmailAddress")]
        public virtual void ResetPersonalEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhoneNumber")]
        public virtual void ResetPhoneNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingAddress")]
        public virtual void ResetShippingAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.CustomerprofilesProfile.CustomerprofilesProfile))!;

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileAddressOutputReference\"}")]
        public virtual aws.CustomerprofilesProfile.CustomerprofilesProfileAddressOutputReference Address
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.CustomerprofilesProfileAddressOutputReference>()!;
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileBillingAddressOutputReference\"}")]
        public virtual aws.CustomerprofilesProfile.CustomerprofilesProfileBillingAddressOutputReference BillingAddress
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.CustomerprofilesProfileBillingAddressOutputReference>()!;
        }

        [JsiiProperty(name: "mailingAddress", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileMailingAddressOutputReference\"}")]
        public virtual aws.CustomerprofilesProfile.CustomerprofilesProfileMailingAddressOutputReference MailingAddress
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.CustomerprofilesProfileMailingAddressOutputReference>()!;
        }

        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileShippingAddressOutputReference\"}")]
        public virtual aws.CustomerprofilesProfile.CustomerprofilesProfileShippingAddressOutputReference ShippingAddress
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.CustomerprofilesProfileShippingAddressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalInformationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdditionalInformationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileAddress\"}", isOptional: true)]
        public virtual aws.CustomerprofilesProfile.ICustomerprofilesProfileAddress? AddressInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.ICustomerprofilesProfileAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AttributesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingAddressInput", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileBillingAddress\"}", isOptional: true)]
        public virtual aws.CustomerprofilesProfile.ICustomerprofilesProfileBillingAddress? BillingAddressInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.ICustomerprofilesProfileBillingAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "birthDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BirthDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "businessEmailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BusinessEmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "businessNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BusinessNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "businessPhoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BusinessPhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "genderStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GenderStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homePhoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomePhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mailingAddressInput", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileMailingAddress\"}", isOptional: true)]
        public virtual aws.CustomerprofilesProfile.ICustomerprofilesProfileMailingAddress? MailingAddressInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.ICustomerprofilesProfileMailingAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "middleNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MiddleNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mobilePhoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MobilePhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partyTypeStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartyTypeStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "personalEmailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersonalEmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shippingAddressInput", typeJson: "{\"fqn\":\"aws.customerprofilesProfile.CustomerprofilesProfileShippingAddress\"}", isOptional: true)]
        public virtual aws.CustomerprofilesProfile.ICustomerprofilesProfileShippingAddress? ShippingAddressInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesProfile.ICustomerprofilesProfileShippingAddress?>();
        }

        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "additionalInformation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalInformation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "birthDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BirthDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "businessEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessEmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "businessPhoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BusinessPhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "genderString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenderString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "homePhoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomePhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddleName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mobilePhoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MobilePhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partyTypeString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartyTypeString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "personalEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersonalEmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
