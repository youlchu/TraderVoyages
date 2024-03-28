import React, { useState } from "react";

type DropdownProps = {
  isOpen: boolean;
  placeHolder: string;
  toggleDropdown: () => void;
  items: string[];
  onItemClick: (item: string) => void;
};

const Dropdown: React.FC<DropdownProps> = ({
  isOpen,
  placeHolder,
  toggleDropdown,
  items,
  onItemClick,
}) => {
  const [selectedItem, setSelectedItem] = useState("");

  const handleItemClick = (item: string) => {
    if (item === "Sıfırla") {
      setSelectedItem("");
      onItemClick("");
    } else {
      onItemClick(item);
      setSelectedItem(item);
    }
    toggleDropdown();
  };

  return (
    <div className="relative w-full">
      <button
        onClick={toggleDropdown}
        className="dropdown-button text-white dark:bg-gray-800 dark:text-white focus:outline-none font-medium rounded-lg text-sm px-5 py-2.5 text-center inline-flex items-center w-full justify-between"
      >
        {selectedItem || placeHolder}
        <svg
          className="w-2.5 h-2.5"
          aria-hidden="true"
          fill="none"
          viewBox="0 0 10 6"
        >
          <path
            stroke="currentColor"
            strokeLinecap="round"
            strokeLinejoin="round"
            strokeWidth="2"
            d="m1 1 4 4 4-4"
          />
        </svg>
      </button>
      {isOpen && (
        <div className="bg-white divide-y divide-gray-100 rounded-lg shadow w-full dark:bg-gray-700 absolute z-10">
          <ul className="py-2 text-sm text-gray-700 dark:text-gray-200">
            {["Sıfırla", ...items].map((item, index) => (
              <li key={index}>
                <a
                  onClick={() => handleItemClick(item)}
                  className="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white w-full"
                >
                  {item}
                </a>
              </li>
            ))}
          </ul>
        </div>
      )}
    </div>
  );
};

export default Dropdown;
