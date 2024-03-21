// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Crypto certificate resource. </summary>
    public partial class CryptoCertificateResult : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CryptoCertificateResult"/>. </summary>
        public CryptoCertificateResult()
        {
            Usage = new ChangeTrackingList<string>();
            FilePaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CryptoCertificateResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="cryptoCertId"> ID for the certificate result. </param>
        /// <param name="namePropertiesName"> Name of the certificate. </param>
        /// <param name="subject"> Subject information of the certificate. </param>
        /// <param name="issuer"> Issuer information of the certificate. </param>
        /// <param name="issuedOn"> Issue date for the certificate. </param>
        /// <param name="expireOn"> Expiration date for the certificate. </param>
        /// <param name="role"> Role of the certificate (Root CA, etc). </param>
        /// <param name="signatureAlgorithm"> The signature algorithm used in the certificate. </param>
        /// <param name="keySize"> Size of the certificate's key in bits. </param>
        /// <param name="keyAlgorithm"> Key algorithm used in the certificate. </param>
        /// <param name="encoding"> Encoding used for the certificate. </param>
        /// <param name="serialNumber"> Serial number of the certificate. </param>
        /// <param name="fingerprint"> Fingerprint of the certificate. </param>
        /// <param name="usage"> List of functions the certificate can fulfill. </param>
        /// <param name="filePaths"> List of files where this certificate was found. </param>
        /// <param name="pairedKey"> A matching paired private key. </param>
        /// <param name="isExpired"> Indicates if the certificate is expired. </param>
        /// <param name="isSelfSigned"> Indicates if the certificate is self-signed. </param>
        /// <param name="isWeakSignature"> Indicates the signature algorithm used is insecure. </param>
        /// <param name="isShortKeySize"> Indicates the certificate's key size is considered too small to be secure for the key algorithm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CryptoCertificateResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string cryptoCertId, string namePropertiesName, CryptoCertificateEntity subject, CryptoCertificateEntity issuer, DateTimeOffset? issuedOn, DateTimeOffset? expireOn, string role, string signatureAlgorithm, long? keySize, string keyAlgorithm, string encoding, string serialNumber, string fingerprint, IList<string> usage, IReadOnlyList<string> filePaths, CryptoPairedKey pairedKey, bool? isExpired, bool? isSelfSigned, bool? isWeakSignature, bool? isShortKeySize, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CryptoCertId = cryptoCertId;
            NamePropertiesName = namePropertiesName;
            Subject = subject;
            Issuer = issuer;
            IssuedOn = issuedOn;
            ExpireOn = expireOn;
            Role = role;
            SignatureAlgorithm = signatureAlgorithm;
            KeySize = keySize;
            KeyAlgorithm = keyAlgorithm;
            Encoding = encoding;
            SerialNumber = serialNumber;
            Fingerprint = fingerprint;
            Usage = usage;
            FilePaths = filePaths;
            PairedKey = pairedKey;
            IsExpired = isExpired;
            IsSelfSigned = isSelfSigned;
            IsWeakSignature = isWeakSignature;
            IsShortKeySize = isShortKeySize;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID for the certificate result. </summary>
        public string CryptoCertId { get; set; }
        /// <summary> Name of the certificate. </summary>
        public string NamePropertiesName { get; set; }
        /// <summary> Subject information of the certificate. </summary>
        public CryptoCertificateEntity Subject { get; set; }
        /// <summary> Issuer information of the certificate. </summary>
        public CryptoCertificateEntity Issuer { get; set; }
        /// <summary> Issue date for the certificate. </summary>
        public DateTimeOffset? IssuedOn { get; set; }
        /// <summary> Expiration date for the certificate. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Role of the certificate (Root CA, etc). </summary>
        public string Role { get; set; }
        /// <summary> The signature algorithm used in the certificate. </summary>
        public string SignatureAlgorithm { get; set; }
        /// <summary> Size of the certificate's key in bits. </summary>
        public long? KeySize { get; set; }
        /// <summary> Key algorithm used in the certificate. </summary>
        public string KeyAlgorithm { get; set; }
        /// <summary> Encoding used for the certificate. </summary>
        public string Encoding { get; set; }
        /// <summary> Serial number of the certificate. </summary>
        public string SerialNumber { get; set; }
        /// <summary> Fingerprint of the certificate. </summary>
        public string Fingerprint { get; set; }
        /// <summary> List of functions the certificate can fulfill. </summary>
        public IList<string> Usage { get; set; }
        /// <summary> List of files where this certificate was found. </summary>
        public IReadOnlyList<string> FilePaths { get; }
        /// <summary> A matching paired private key. </summary>
        public CryptoPairedKey PairedKey { get; set; }
        /// <summary> Indicates if the certificate is expired. </summary>
        public bool? IsExpired { get; set; }
        /// <summary> Indicates if the certificate is self-signed. </summary>
        public bool? IsSelfSigned { get; set; }
        /// <summary> Indicates the signature algorithm used is insecure. </summary>
        public bool? IsWeakSignature { get; set; }
        /// <summary> Indicates the certificate's key size is considered too small to be secure for the key algorithm. </summary>
        public bool? IsShortKeySize { get; set; }
    }
}
