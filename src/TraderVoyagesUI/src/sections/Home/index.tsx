import React, { useState } from "react";
import { Formik, Form, Field } from "formik";
import * as Yup from "yup";
import Dropdown from "../../components/Dropdown";
import { useNavigate } from "react-router-dom";

const Home: React.FC = () => {
  const navigate = useNavigate();
  const [isOpen1, setIsOpen1] = useState(false);
  const [isOpen2, setIsOpen2] = useState(false);

  const toggleDropdown1 = () => setIsOpen1(!isOpen1);
  const toggleDropdown2 = () => setIsOpen2(!isOpen2);
  const [isSubmittedPlayer1, setIsSubmittedPlayer1] = useState(false);
  const [isSubmittedPlayer2, setIsSubmittedPlayer2] = useState(false);
  const [startAnimation, setStartAnimation] = useState(false);

  const items = ["At", "Deve", "Fil"];

  const PlayerSchema = Yup.object().shape({
    userName: Yup.string()
      .required("Kullanıcı adı zorunludur")
      .min(3, "Kullanıcı adı en az 3 karakter olmalıdır"),
    animal: Yup.string().required("Binek hayvanı zorunludur"),
  });

  const onSubmit =
    (playerNumber: number) =>
    (
      values: { userName: string; animal: string },
      actions: {
        setFieldTouched: (
          field: string,
          isTouched: boolean,
          shouldValidate?: boolean
        ) => void;
        setFieldValue: (field: string, value: string) => void;
      }
    ) => {
      actions.setFieldTouched("userName", true, false);
      actions.setFieldTouched("animal", true, false);
      console.log(values);

      if (playerNumber === 1) {
        setIsSubmittedPlayer1(true);
      } else if (playerNumber === 2) {
        setIsSubmittedPlayer2(true);
      }

      if (isSubmittedPlayer1 && isSubmittedPlayer2) {
        setStartAnimation(true);
        setTimeout(() => {
          navigate("/game");
        }, 3000); // Animasyon süresiyle eşleşen zaman aşımı
      }
    };

  return (
    <div
      className={`flex justify-center items-center h-screen ${
        startAnimation ? "mergeAndFade" : ""
      }`}
    >
      <div className="absolute logo top-0 left-0 right-0 flex justify-center items-center">
        <img src="src\assets\images\logo.webp" alt="logo" />
      </div>

      <div className="w-1/2 flex flex-col justify-center items-center h-full border-dotted border-r-2 border-gray-900">
        <div className="relative p-6 border-2 border-gray-900">
          <div className="border-dark-edge-left" />
          <h1 className="text-2xl font-bold mb-4">Oyuncu 1</h1>
          <Formik
            initialValues={{ userName: "", animal: "" }}
            validationSchema={PlayerSchema}
            onSubmit={onSubmit(1)}
          >
            {(formProps) => (
              <Form className="flex flex-col items-center">
                <div className="relative w-full mb-5">
                  <Field
                    name="userName"
                    type="text"
                    placeholder="Kullanıcı Adı"
                    className="input-style w-full"
                  />
                  {formProps.errors.userName && formProps.touched.userName && (
                    <div className="absolute text-red-500 text-xs italic">
                      {formProps.errors.userName}
                    </div>
                  )}
                </div>
                <div className="relative mb-4 w-full">
                  <Dropdown
                    isOpen={isOpen1}
                    toggleDropdown={toggleDropdown1}
                    placeHolder="Binek Hayvan Seçiniz"
                    items={items}
                    onItemClick={(item) => {
                      formProps.setFieldValue("animal", item);
                      formProps.setFieldTouched("animal", true, false);
                    }}
                  />
                  {formProps.errors.animal && formProps.touched.animal && (
                    <div className="absolute text-red-500 text-xs italic">
                      {formProps.errors.animal}
                    </div>
                  )}
                </div>
                {isSubmittedPlayer1 ? (
                  <div className="text-green-500">
                    Oyuncu 1 bilgileri alındı
                  </div>
                ) : (
                  <button type="submit" className="mt-4 button-style">
                    Gönder
                  </button>
                )}
              </Form>
            )}
          </Formik>
        </div>
      </div>

      <div className="w-1/2 flex flex-col justify-center items-center h-full border-dotted border-r-2 border-gray-900">
        <div className="relative p-6 border-2 border-gray-900">
          <div className="border-dark-edge-right" />
          <h1 className="text-2xl font-bold mb-4">Oyuncu 2</h1>
          <Formik
            initialValues={{ userName: "", animal: "" }}
            validationSchema={PlayerSchema}
            onSubmit={onSubmit(2)}
          >
            {(formProps) => (
              <Form className="flex flex-col items-center">
                <div className="relative w-full mb-5">
                  <Field
                    name="userName"
                    type="text"
                    placeholder="Kullanıcı Adı"
                    className="input-style w-full"
                  />
                  {formProps.errors.userName && formProps.touched.userName && (
                    <div className="absolute text-red-500 text-xs italic">
                      {formProps.errors.userName}
                    </div>
                  )}
                </div>
                <div className="relative mb-4 w-full">
                  <Dropdown
                    isOpen={isOpen2}
                    toggleDropdown={toggleDropdown2}
                    placeHolder="Binek Hayvan Seçiniz"
                    items={items}
                    onItemClick={(item) => {
                      formProps.setFieldValue("animal", item);
                      formProps.setFieldTouched("animal", true, false);
                    }}
                  />
                  {formProps.errors.animal && formProps.touched.animal && (
                    <div className="absolute text-red-500 text-xs italic">
                      {formProps.errors.animal}
                    </div>
                  )}
                </div>
                {isSubmittedPlayer2 ? (
                  <div className="text-green-500">
                    Oyuncu 2 bilgileri alındı
                  </div>
                ) : (
                  <button type="submit" className="mt-4 button-style">
                    Gönder
                  </button>
                )}
              </Form>
            )}
          </Formik>
        </div>
      </div>
    </div>
  );
};

export default Home;
